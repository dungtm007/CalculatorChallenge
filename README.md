# CalculatorChallenge
Calculator Challenge - Coding Practice

**1. Commit for requirement 1:** Support a maximum of 2 numbers using a comma delimiter
  * Initial idea: apply Chain of Responsibilities pattern, there will be different input parsers corresponding with different supported formats in every requirements. These parsers sequentially try to parse input with their own supported format till they can return the list of operand numbers.
  * This commit introduced the first parser: CommaDelimiterParser
  
    ![calculator requirement 1](https://lh3.googleusercontent.com/XUeL0XNedUhBjY7DHCRWWZo09Bf46h4cUNBmGtJ7uksrHuIjdSguxYWA0y6-3s1oDJWZ8iHgPZDDPch-uRLdSIwuRjqYdLhOWBbBwiKCfrmvk5_yLMbeEgCGbFffU0Om1Y1YtKDQN3WiwyGp8EbRiPOc4cSe7oifLWnrcgpZCvnQ3yBQ1gZaBqeebXb7bgyuSJCqFTduovVFH6MuGNWy51cxMIYtfKjq8WK7oc3tPG1TNYjVvUEMCvSRGy10eJe4ECmqhhK4fEtjhx5vIsUbF5O0QOXf7bkZHeqI3DKh0TjXQ2qYhYhlEFV0f0823uK-tck_QbSLlsqHY-ymNJekpe_JiTwT5spJUjBjBo4b9SpGLbQL8S_Z8yskTjlnbVjyzBBLsL714a9LrX_q7jefRWEpbvoZpwHV3896fc4avEhatEe1foHw_MZm07b_GFousJkty2IGrA1QHU-HXCamRG2vylYgoSDR87Ug-o14mUcyiKFFfUZ_q--3-RAELFJ8G69hNbnvfB2aeoOAk18n4OVR5MGOyg9v_mfvIsfpMhskAuUffrlMwWBL9Ii9_WFQpFBBkGL__mFJceRVij_7Yv4pe73ndZC5GjvHFDGp43zxgmjKZ2jDd50=s440-w440-h258-no)

**2. Commit for requirement 2:** Support unlimited number of numbers using a comma delimiter
  * This is an updated version of the first requirement. Since there is already CommaDelimiterParser class that supports logic for property SupportedNumberOfOperands, just needs to update the property value to 1 (or either -1 or 0 also works)
  
     ![calculator requirement 2](https://lh3.googleusercontent.com/v7YycGQkWvsltpMQ_wA9AJx0izqQA_XO_26dWFVv5Y_PndSjlbPTJIQkJ8y89qHU0WLLaHm15gILHjiAjrm96l6rAKKsuceRLmzcxiFJ2NJ542ZntW8EPIY1OD_J7_U9KqebWgx1JUNV0h-Tb16jRzvYUiaA37IdNo4krI4F96stZG9ZBCEHXJNiqWtFLifFYm_k5plJcy-zyWYMqVYSNbbA30LynemuIZdOabrbVr7KnX4gRuz7-LtL2cbCRXyqzXtyJyII1Vb5UcYcDjQbW3oDkQmhkfJvDFu_YFgaj2bQVnWWTrgIqYCcfFcbueqUf4usfzNZ-KCasUTMzdx62NV7OxMOE9SqUc9E8ozk-fZ8wQJsXrI4zbhXrcnBGKcq7oQLm8KVZzZ2his7y0ZD4DXAyB-L6brN2Ri94QMKDgjXjcbmGC1hbPL3ezGcKHxEI6lnW0A-LjBT47ppUICKa-ulZbgr-U8G76zI74ZOj7CDECqwE0ZmHrvDVtRvhWxzDoWRUmPIKF-Pzcqw7e6hseIV9WQ2CId29Pvv61NtJr0pGEgKwY2XtJVG7mGRbF4A6SGkA013zRj_Fg0Z7LZEuC7mE3sT7lXQGOa2J-tTE9dBXECmqLe9NaET41zj0sm4QxYsMYZLhMVVGdgzyDspcQGuY2dRswdazZcyjjEbBFwTu9xdQo42SA=w482-h269-no)
     
   
**3. Commit for requirement 3:** Support a newline character as an alternative delimiter
  * Added a new input parser that support different delimiter
  * There is one unclear point here: the problem says input is "1\n2,3", and not sure the new line character here "\n" is as its text or it's actually a new line entered from keyboard (press Enter)? I consider dealing with reading Enter keypress as new line is a bit difficult to differentiate with the last Enter to notify finishing input, so I made one assumption here: to have new line character "\n" to be enter as text 
  * The below example demonstrates that for both formats so far (all comma or comma and "\n") the calculator can still support
  
    ![calculator requirement 3](https://lh3.googleusercontent.com/7xsXeSAvg1OKmGL_86Nlt-QeMi0QCUtO71dtBHHJ9QqQJGsMoPT8Zt9_7D28cD2W9cYbdIgw6EuMKt2vCPlaz6o4Goi_mgCc9fCIME-ETuhO1W3kqI-ez9xStQ8gR4Au4pwz22_FAv27K7_3Qjbmoi7S-XzR2Kc8MLAJEP23Nbt77104ryAXlmdIXBEpamF-FOsGKtMCOuSZ3sC-P7bGRYV_KyVHVvgBxaWGJcHB5QJ0gMEufzDgNA3CQATKWos91BqkcZvKDPSlaI9MjN_BmSedJDs4UhBYIuDZ66v3XsvcT2xBJYRlX-_dIqQb1mZJ3LJF5P6TzYaKS-NgqRRDCoR1T4SZfdWDw7a-6KORwtRFEnCEWQVjoeedXubCJLidoruucIOEywnd2an4ZIOpXP8TvqVM2FEO2No9BwbDb7PSuqqwOb8JBFd83ErMMkSxNavqSOXLx_TfyvWcJc1facdi76HTtbPMYYrUX0wkF4MeWQKYXIWjcwsWdeIJc1IXmXSwc6kR7MswJt9RQ_byeCF0LXnsemjh4fmw4mFTi0NlfZsAcW7qI2oS7-O4DsHpYoijrg8FfYkNrKhLY64NwlEsGM-czXXjcZ_XWgNC4kAMA4qc-xUipdFiyH5Gbf_tTsZNjun2D4WiEWJhSWFufROQffKHmb7yUop656xKV310i8jW36wfNA=w445-h161-no)
  
  **4. Commit for requirement 4:** Deny negative numbers. An exception should be thrown that includes all of the negative numbers provided
  * Added a new concept: validator, which is used to validate list of numbers (in this case only allow positive number)
  * Refactored InputParser code, to have delegate action to be on base class
  * Added unit tests for classes so far
  
     ![calculator requirement 4](https://lh3.googleusercontent.com/jluzEqfCk4UgMj-PRDKl6wT1h_f6BH9BbqkHQZ36AugKkeD7iamZROL_2-FjP0bPws-8_2BPaJ46QKb7J2-RxFpNNUFaqboEFU2tkkXwz_5_sBOvkHbwfpuIPOn73L-ZvJw70hrZatqD5-SlSNy7N8IFyrJVy_cicQKWMNb4MVUMP6qPaGaUZVFIpY3UKtEH65kwmeaOHMIttuKEKPAnUCPgq6nAWQErd8Eg9f7gzylVPW4ZwMLgD5juMi7TtG_jk0NiT3k7k46NcJx4SuHcKFbMkqFMweenVwNiaFaHS2mymH-6cCLsOnkGrn_eBDoVnKu4qw7yn8ZeIeRaVg-BRoO5XbHfaFJ0eo0h1_VhnF9-5Sgit6IAE628N6BJe2vwdGTbpPLlAEDcNiItIIxDVd3-0sVVkxdfCy63KTqlJYw1o5Va4XLHY_qB0QwfKoW73Ip46FMIawBYI3VNmrSIrgdx8kpUwOI0XBeGmfgZCIgn5XV_cFie_g3tt2iOgvqizZop7zH0H8NoPj9k3Ixp32ON2CL8YqXQfvqSn1uFVk3xOgKu2e4tC54StwISEuQwBv3H4f9spdYdsg_wWJK_UHIU1e-OM2XqSLtTQ8H7Vr3T_FJt0zw3dBt7VfAeiSI8GV6-PeLXL9_RD7PgSs3VDYiOuS0veq3GTGqmO5OJ9j9u4EU-6o009A=w511-h82-no)
  
  
  
  
