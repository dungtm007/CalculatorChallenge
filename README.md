# CalculatorChallenge
Calculator Challenge - Coding Practice

**1. First Commit:** accomplish requirement 1 - Support a maximum of 2 numbers using a comma delimiter
  * Initial idea: apply Chain of Responsibilities pattern, there will be different input parsers corresponding with different supported formats in every requirements. These parsers sequentially try to parse input with their own supported format till they can return the list of operand numbers.
  * This commit introduced the first parser: CommaDelimiterParser
  
     ![calculator requirement 1](https://lh3.googleusercontent.com/Xv3GGQZuuI375mm2pAUlUzdFVvAZZWdJuWHhKNIaGULZwCuPTGENQuA6vE_r_t4qslUWYpvXjd7pd0pL8PHm8TQ8aCBrMNjonDD-9xB64rBKIBtZnau3411Hz6-aaV4RvOazBR8IrJxVTvzf8OEl7UZQCqP0TIkEEB6WC7HjRUoRMBeUTOvut2bIefBJdXtG9V3u69ywC4jWuWXfpz14zHrAWEu8mqvMvnuCwsLrPCOxcESrq4nstWIERQhX1jf-4mYH2yeLsPaSVCdea-NTre-GIr6I5C1Rkr6YMHDlridTVBKs09MJEzAElNykYv2r6_d3ZhWcKO4WT67RX7fIsx-NMiV6aLYIHJCflvXcgLwzuDcqpXZRIocYtNkVA-1P-1FqcsBploMeKCfTslNPhbwhRINOKNJgryQCr9t1MpKPTXr7mQGNZETS-SfT-w2DZGq2Izq2k9Bi2Zq8k-Fo6kiE4Q_qb3JOeTYFWnhmkSfJmid0opyN6XyCATldcTWQQVx9jEJcUWhCQS6FvlVM6kG17wELOsKkz0q9c5HdR0sIVT8xv9fdlKP5PjMPpVocN811PQV4U_A0hZu2lnk3Kg60Kz_9WCHrckO46cd88BZkB7jSMH6fuS2DhBIcYCIOu30y2RYW9Wb1a4LFoBWyWBS6gnLEf4JlzBLbIMwtVCnGPFjvqkyDYA=w375-h220-no)


