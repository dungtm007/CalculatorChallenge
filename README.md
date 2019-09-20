# CalculatorChallenge
Calculator Challenge - Coding Practice

**1. Commit for requirement 1:** Support a maximum of 2 numbers using a comma delimiter
  * Initial idea: apply Chain of Responsibilities pattern, there will be different input parsers corresponding with different supported formats in every requirements. These parsers sequentially try to parse input with their own supported format till they can return the list of operand numbers.
  * This commit introduced the first parser: CommaDelimiterParser
  
     ![calculator requirement 1](https://lh3.googleusercontent.com/Xv3GGQZuuI375mm2pAUlUzdFVvAZZWdJuWHhKNIaGULZwCuPTGENQuA6vE_r_t4qslUWYpvXjd7pd0pL8PHm8TQ8aCBrMNjonDD-9xB64rBKIBtZnau3411Hz6-aaV4RvOazBR8IrJxVTvzf8OEl7UZQCqP0TIkEEB6WC7HjRUoRMBeUTOvut2bIefBJdXtG9V3u69ywC4jWuWXfpz14zHrAWEu8mqvMvnuCwsLrPCOxcESrq4nstWIERQhX1jf-4mYH2yeLsPaSVCdea-NTre-GIr6I5C1Rkr6YMHDlridTVBKs09MJEzAElNykYv2r6_d3ZhWcKO4WT67RX7fIsx-NMiV6aLYIHJCflvXcgLwzuDcqpXZRIocYtNkVA-1P-1FqcsBploMeKCfTslNPhbwhRINOKNJgryQCr9t1MpKPTXr7mQGNZETS-SfT-w2DZGq2Izq2k9Bi2Zq8k-Fo6kiE4Q_qb3JOeTYFWnhmkSfJmid0opyN6XyCATldcTWQQVx9jEJcUWhCQS6FvlVM6kG17wELOsKkz0q9c5HdR0sIVT8xv9fdlKP5PjMPpVocN811PQV4U_A0hZu2lnk3Kg60Kz_9WCHrckO46cd88BZkB7jSMH6fuS2DhBIcYCIOu30y2RYW9Wb1a4LFoBWyWBS6gnLEf4JlzBLbIMwtVCnGPFjvqkyDYA=w375-h220-no)

**2. Commit for requirement 2:** Support unlimited number of numbers using a comma delimiter
  * This is an updated version of the first requirement. Since there is already CommaDelimiterParser class that supports logic for property SupportedNumberOfOperands, just needs to update the property value to 1 (or either -1 or 0 also works)
  
     ![calculator requirement 2](https://lh3.googleusercontent.com/v7YycGQkWvsltpMQ_wA9AJx0izqQA_XO_26dWFVv5Y_PndSjlbPTJIQkJ8y89qHU0WLLaHm15gILHjiAjrm96l6rAKKsuceRLmzcxiFJ2NJ542ZntW8EPIY1OD_J7_U9KqebWgx1JUNV0h-Tb16jRzvYUiaA37IdNo4krI4F96stZG9ZBCEHXJNiqWtFLifFYm_k5plJcy-zyWYMqVYSNbbA30LynemuIZdOabrbVr7KnX4gRuz7-LtL2cbCRXyqzXtyJyII1Vb5UcYcDjQbW3oDkQmhkfJvDFu_YFgaj2bQVnWWTrgIqYCcfFcbueqUf4usfzNZ-KCasUTMzdx62NV7OxMOE9SqUc9E8ozk-fZ8wQJsXrI4zbhXrcnBGKcq7oQLm8KVZzZ2his7y0ZD4DXAyB-L6brN2Ri94QMKDgjXjcbmGC1hbPL3ezGcKHxEI6lnW0A-LjBT47ppUICKa-ulZbgr-U8G76zI74ZOj7CDECqwE0ZmHrvDVtRvhWxzDoWRUmPIKF-Pzcqw7e6hseIV9WQ2CId29Pvv61NtJr0pGEgKwY2XtJVG7mGRbF4A6SGkA013zRj_Fg0Z7LZEuC7mE3sT7lXQGOa2J-tTE9dBXECmqLe9NaET41zj0sm4QxYsMYZLhMVVGdgzyDspcQGuY2dRswdazZcyjjEbBFwTu9xdQo42SA=w482-h269-no)
     
   
**3. Commit for requirement 3:** accomplish requirement 3 - Support a newline character as an alternative delimiter
  * Added a new input parser that support different delimiter
  * There is one unclear point here: the problem says input is "1\n2,3", and not sure the new line character here "\n" is as its text or it's actually a new line entered from keyboard (press Enter)? I consider dealing with reading Enter keypress as new line is a bit difficult to differentiate with the last Enter to notify finishing input, so I made one assumption here: to have new line character "\n" to be enter as text 
  * The below example demonstrates that for both formats so far (all comma or comma and "\n") the calculator can still support
  
    ![calculator requirement 3](https://lh3.googleusercontent.com/7xsXeSAvg1OKmGL_86Nlt-QeMi0QCUtO71dtBHHJ9QqQJGsMoPT8Zt9_7D28cD2W9cYbdIgw6EuMKt2vCPlaz6o4Goi_mgCc9fCIME-ETuhO1W3kqI-ez9xStQ8gR4Au4pwz22_FAv27K7_3Qjbmoi7S-XzR2Kc8MLAJEP23Nbt77104ryAXlmdIXBEpamF-FOsGKtMCOuSZ3sC-P7bGRYV_KyVHVvgBxaWGJcHB5QJ0gMEufzDgNA3CQATKWos91BqkcZvKDPSlaI9MjN_BmSedJDs4UhBYIuDZ66v3XsvcT2xBJYRlX-_dIqQb1mZJ3LJF5P6TzYaKS-NgqRRDCoR1T4SZfdWDw7a-6KORwtRFEnCEWQVjoeedXubCJLidoruucIOEywnd2an4ZIOpXP8TvqVM2FEO2No9BwbDb7PSuqqwOb8JBFd83ErMMkSxNavqSOXLx_TfyvWcJc1facdi76HTtbPMYYrUX0wkF4MeWQKYXIWjcwsWdeIJc1IXmXSwc6kR7MswJt9RQ_byeCF0LXnsemjh4fmw4mFTi0NlfZsAcW7qI2oS7-O4DsHpYoijrg8FfYkNrKhLY64NwlEsGM-czXXjcZ_XWgNC4kAMA4qc-xUipdFiyH5Gbf_tTsZNjun2D4WiEWJhSWFufROQffKHmb7yUop656xKV310i8jW36wfNA=w445-h161-no)
  
  
