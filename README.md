# CalculatorChallenge
Calculator Challenge - Coding Practice

**1. First Commit:** accomplish requirement 1 - Support a maximum of 2 numbers using a comma delimiter
  * Initial idea: apply Chain of Responsibilities pattern, there will be different input parsers corresponding with different supported formats in every requirements. These parsers sequentially try to parse input with their own supported format till they can return the list of operand numbers.
  * This commit introduced the first parser: CommaDelimiterParser
  
     ![calculator requirement 1](https://lh3.googleusercontent.com/Xv3GGQZuuI375mm2pAUlUzdFVvAZZWdJuWHhKNIaGULZwCuPTGENQuA6vE_r_t4qslUWYpvXjd7pd0pL8PHm8TQ8aCBrMNjonDD-9xB64rBKIBtZnau3411Hz6-aaV4RvOazBR8IrJxVTvzf8OEl7UZQCqP0TIkEEB6WC7HjRUoRMBeUTOvut2bIefBJdXtG9V3u69ywC4jWuWXfpz14zHrAWEu8mqvMvnuCwsLrPCOxcESrq4nstWIERQhX1jf-4mYH2yeLsPaSVCdea-NTre-GIr6I5C1Rkr6YMHDlridTVBKs09MJEzAElNykYv2r6_d3ZhWcKO4WT67RX7fIsx-NMiV6aLYIHJCflvXcgLwzuDcqpXZRIocYtNkVA-1P-1FqcsBploMeKCfTslNPhbwhRINOKNJgryQCr9t1MpKPTXr7mQGNZETS-SfT-w2DZGq2Izq2k9Bi2Zq8k-Fo6kiE4Q_qb3JOeTYFWnhmkSfJmid0opyN6XyCATldcTWQQVx9jEJcUWhCQS6FvlVM6kG17wELOsKkz0q9c5HdR0sIVT8xv9fdlKP5PjMPpVocN811PQV4U_A0hZu2lnk3Kg60Kz_9WCHrckO46cd88BZkB7jSMH6fuS2DhBIcYCIOu30y2RYW9Wb1a4LFoBWyWBS6gnLEf4JlzBLbIMwtVCnGPFjvqkyDYA=w375-h220-no)

**2. Second Commit:** accomplish requirement 2 - Support unlimited number of numbers using a comma delimiter
  * This is an updated version of the first requirement. Since there is already CommaDelimiterParser class that supports logic for property SupportedNumberOfOperands, just needs to update the property value to 1 (or either -1 or 0 also works)
  
     ![calculator requirement 1](https://lh3.googleusercontent.com/k_kYzz45aBBfG6aku4gkyObbP5XSljenKVfVj1bW4-i8EbodKtr4aeIWhEU5uLRBG91dSpVvBZypkpmZe3NSTiXIS7EK0-wFlvaTgNQJHypjczW0PbSr4WiNxB_khtqQ7OoWdvD_3Ye1nZTBZPJLysGR1kN8jWaVB6h6YseOV1G6q8aHIDKqwdUx6ZVedE1Ig2jE7lq8dAUD2nTSXouzPypTnVBUkgYpe8vOp-VPNng8qSb5Kig4WgZkXOfyf4LU9enw0p5vI6Ycw1o92ZcgfD0eP__UmMjWEBIoVtEZhCF-Si0f4QOPTWkNlEHgIXDBmhqJdVOes8YUASsH2gFupGs6bn09sycgThRkajOnda5_E56N-_I67ceA99J3LLeKLENF1UhQij1aeIJfj0Or0ZpH0wg0Vyc8ma5umA_zDkcr1tAveXaFzPIJc9zYrQcswUCx0p-ME1WsSTIqUj3iT8zGPBWValQkAWHfhTxTBxCfMAKRRNJ4bDRxk0KXx-4b7iGxVYaYjWz4XBJKpWl8ewU7oMkIQTn78kRXwViRPV-A-Qi-llllnDyrM9zsV0yJWBTNpU0wbiFcz8XaWmZr1L1IIiIz3j5tJxT3OCFKsPWA4NI7XEVrTkldb0S3B9NhmnI_KSlFIJPkHoN1UYnZo6ZrGK_aiMAnid9TfoF4GSW5n4rZ17tmmw=w482-h269-no)
     
     
