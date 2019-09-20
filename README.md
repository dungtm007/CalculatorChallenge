# CalculatorChallenge
Calculator Challenge - Coding Practice

**1. First Commit:** accomplish requirement 1 - Support a maximum of 2 numbers using a comma delimiter
  * Initial idea: apply Chain of Responsibilities pattern, there will be different input parsers corresponding with different supported formats in every requirements. These parsers sequentially try to parse input with their own supported format till they can return the list of operand numbers.
  * This commit introduced the first parser: CommaDelimiterParser
  
     ![calculator requirement 1](https://lh3.googleusercontent.com/Xv3GGQZuuI375mm2pAUlUzdFVvAZZWdJuWHhKNIaGULZwCuPTGENQuA6vE_r_t4qslUWYpvXjd7pd0pL8PHm8TQ8aCBrMNjonDD-9xB64rBKIBtZnau3411Hz6-aaV4RvOazBR8IrJxVTvzf8OEl7UZQCqP0TIkEEB6WC7HjRUoRMBeUTOvut2bIefBJdXtG9V3u69ywC4jWuWXfpz14zHrAWEu8mqvMvnuCwsLrPCOxcESrq4nstWIERQhX1jf-4mYH2yeLsPaSVCdea-NTre-GIr6I5C1Rkr6YMHDlridTVBKs09MJEzAElNykYv2r6_d3ZhWcKO4WT67RX7fIsx-NMiV6aLYIHJCflvXcgLwzuDcqpXZRIocYtNkVA-1P-1FqcsBploMeKCfTslNPhbwhRINOKNJgryQCr9t1MpKPTXr7mQGNZETS-SfT-w2DZGq2Izq2k9Bi2Zq8k-Fo6kiE4Q_qb3JOeTYFWnhmkSfJmid0opyN6XyCATldcTWQQVx9jEJcUWhCQS6FvlVM6kG17wELOsKkz0q9c5HdR0sIVT8xv9fdlKP5PjMPpVocN811PQV4U_A0hZu2lnk3Kg60Kz_9WCHrckO46cd88BZkB7jSMH6fuS2DhBIcYCIOu30y2RYW9Wb1a4LFoBWyWBS6gnLEf4JlzBLbIMwtVCnGPFjvqkyDYA=w375-h220-no)

**2. Second Commit:** accomplish requirement 2 - Support unlimited number of numbers using a comma delimiter
  * This is an updated version of the first requirement. Since there is already CommaDelimiterParser class that supports logic for property SupportedNumberOfOperands, just needs to update the property value to 1 (or either -1 or 0 also works)
  
     ![calculator requirement 2](https://lh3.googleusercontent.com/v7YycGQkWvsltpMQ_wA9AJx0izqQA_XO_26dWFVv5Y_PndSjlbPTJIQkJ8y89qHU0WLLaHm15gILHjiAjrm96l6rAKKsuceRLmzcxiFJ2NJ542ZntW8EPIY1OD_J7_U9KqebWgx1JUNV0h-Tb16jRzvYUiaA37IdNo4krI4F96stZG9ZBCEHXJNiqWtFLifFYm_k5plJcy-zyWYMqVYSNbbA30LynemuIZdOabrbVr7KnX4gRuz7-LtL2cbCRXyqzXtyJyII1Vb5UcYcDjQbW3oDkQmhkfJvDFu_YFgaj2bQVnWWTrgIqYCcfFcbueqUf4usfzNZ-KCasUTMzdx62NV7OxMOE9SqUc9E8ozk-fZ8wQJsXrI4zbhXrcnBGKcq7oQLm8KVZzZ2his7y0ZD4DXAyB-L6brN2Ri94QMKDgjXjcbmGC1hbPL3ezGcKHxEI6lnW0A-LjBT47ppUICKa-ulZbgr-U8G76zI74ZOj7CDECqwE0ZmHrvDVtRvhWxzDoWRUmPIKF-Pzcqw7e6hseIV9WQ2CId29Pvv61NtJr0pGEgKwY2XtJVG7mGRbF4A6SGkA013zRj_Fg0Z7LZEuC7mE3sT7lXQGOa2J-tTE9dBXECmqLe9NaET41zj0sm4QxYsMYZLhMVVGdgzyDspcQGuY2dRswdazZcyjjEbBFwTu9xdQo42SA=w482-h269-no)
     
     
