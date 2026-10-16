
lambda { |stdout,stderr,status|
  output = stdout + stderr

  # MSTest ends with a block of counts, which is what this reads. Matching the
  # counts rather than any wording means a reworded banner cannot silently
  # change a colour.
  #
  #   Test run summary: Failed! - /sandbox/bin/dojo.dll (net10.0|arm64)
  #     total: 3
  #     failed: 1
  #     succeeded: 2
  #     skipped: 0
  #
  # A compile that failed prints no such block at all, and reaches the amber at
  # the bottom. The exit status cannot do this job: an assertion failure and a
  # thrown exception both exit 2.
  total  = /^\s*total:\s*(\d+)/.match(output)
  failed = /^\s*failed:\s*(\d+)/.match(output)

  if total && failed
    # Nothing ran, so there is nothing to be green about.
    return :amber if total[1].to_i.zero?
    return :green if failed[1].to_i.zero?

    # A failed assertion is red and a thrown exception is amber, and MSTest
    # counts both of them as failed, so the counts cannot tell them apart. The
    # line under each failure can: an assertion names itself, and anything else
    # says the test method threw.
    #
    #     failed three_fails (5ms)
    #       Assertion failed. Expected values to be equal.
    #     failed one_errors (5ms)
    #       Test method HikerTest.one_errors threw exception:
    #
    # Every failure has to be an assertion for this to be red. One that is not
    # means something went wrong rather than something being wrong.
    failures = output.scan(/^failed \S+ \(\d+ms\)/).size
    assertions = output.scan(/^\s*Assertion failed\./).size
    return :red if failures.positive? && failures == assertions
    return :amber
  end

  return :amber
}
