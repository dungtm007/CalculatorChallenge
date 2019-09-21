# CalculatorChallenge
Calculator Challenge - Coding Practice

**1. Commit for requirement 1:** Support a maximum of 2 numbers using a comma delimiter
  * Initial idea: apply Chain of Responsibilities pattern, there will be different input parsers corresponding with different supported formats in every requirements. These parsers sequentially try to parse input with their own supported format till they can return the list of operand numbers.
  * This commit introduced the first parser: CommaDelimiterParser
  
    ![calculator requirement 1](https://i.ibb.co/b6NFg1k/calculator-1.png)

**2. Commit for requirement 2:** Support unlimited number of numbers using a comma delimiter
  * This is an updated version of the first requirement. Since there is already CommaDelimiterParser class that supports logic for property SupportedNumberOfOperands, just needs to update the property value to 1 (or either -1 or 0 also works)
  
     ![calculator requirement 2](https://i.ibb.co/SnT7mnp/calculator-2.png)
     
   
**3. Commit for requirement 3:** Support a newline character as an alternative delimiter
  * Added a new input parser that support different delimiter
  * There is one unclear point here: the problem says input is "1\n2,3", and not sure the new line character here "\n" is as its text or it's actually a new line entered from keyboard (press Enter)? I consider dealing with reading Enter keypress as new line is a bit difficult to differentiate with the last Enter to notify finishing input, so I made one assumption here: to have new line character "\n" to be enter as text 
  * The below example demonstrates that for both formats so far (all comma or comma and "\n") the calculator can still support
  
    ![calculator requirement 3](https://i.ibb.co/gRbnGcP/calculator-3.png)
  
  **4. Commit for requirement 4:** Deny negative numbers. An exception should be thrown that includes all of the negative numbers provided
  * Added a new concept: validator, which is used to validate list of numbers (in this case only allow positive number)
  * Refactored InputParser code, to have delegate action to be on base class
  * Added unit tests for classes so far
  
     ![calculator requirement 4](https://i.ibb.co/JsHMSdf/calculator-4.png)
  
  **5. Commit for requirement 5:** Ignore any number greater than 1000
  * Added a new concept: filter, which is used to filter the final list of numbers
  * Also, refactored the code structure a bit, e.g. all parsers, validators, filters are now under Internal folder
  
  **6. Commit for requirement 6:** Support 1 custom single character length delimiter
  * Make sure all previous format is still supported
  
     ![calculator requirement 6](https://i.ibb.co/dJXthSc/calculator-6.png)
     
  **7. Commit for requirement 7:** Support 1 custom delimiter of any length
  * Also, fixed one crucial issue: in abstract InputParser, the call to NextInputParser should be ParseOrPassToNextInputParserIfNeeded
  
     ![calculator requirement 7](https://i.ibb.co/FDvxvqY/calculator-7.png)
  
  **8. Commit for requirement 8:** Support multiple delimiters of any length
  * Some tests:
  
       ![calculator requirement 8](https://i.ibb.co/t48BTvm/calculator-8.png)
       
  **Stretch goal 1. Commit for stretch goal 1:** Display the formula used to calculate the result e.g. 2,4,rrrr,1001,6 will return 2+4+0+0+6 = 12
  * Added ParsedNumbers and Result properties to Calculator class. Then implemented a DisplayResult method to print the formula
     
      ![calculator stretch goal 1](https://i.ibb.co/HHH0Vh8/calculator-stretch-1.png)
      
  **Stretch goal 2. Commit for stretch goal 2:** Allow the application to process entered entries until Ctrl+C is used
  * Actually this task is simple. Because the default behavior of Windows console is always stop whenever Ctrl+C is pressed. Therefore, the code change in this commit make the code cleaner with a simple while(true) loop
  * A final testing also makes sure all required formats are supported well:
  
      ![calculator stretch goal 2](https://i.ibb.co/LhTyN7F/calculator-stretch-2.png)

---
### Notes for points that are not implemeted

I don't want to make the app too overcomplicated with some more flexibility, as I hope readers can read less code to focus and get the main ideas/main flows  that accomplished the core requirements. Below are my thoughts if I would need to implement more...

#### Strech goals
**Stretch goal 3: Allow the acceptance of arguments to define...**

    alternate delimiter in step #3
    toggle whether to deny negative numbers in step #4
    upper bound in step #5
    
  * For now, the DifferentDelimitersParser to support step #3 already exposed constructor to pass in the supported delimiters. It's not fixed, therefore client can totally pass whatever delimiters to make it work
  * The validation at step #4 is materialized as an instance of INumberValidator. It's possible to ask user if he wants to include negative number. Then we can pass in either the currently used PositiveNumberValidator (if needs to deny negative numbers) or another BlankValidator (a validator that actually validate no rules - the IsValid method always returns true). The idea here is programming agains interface INumberValidator and pass the appropriate instance 
  * Again for upper bound in step #5, the current implementation for excluding numbers greater than 1000 is using a INumberFilter. The same idea with INumberValidator, easily to pass in the appropriate instance filter according to specific need. The app can also be modified to accept multiple filters.
  
**Stretch goal 4: Use DI**
  * It's easy to configure DI using service provider for Console application. However, as the current app does not use too many interfaces (only an instance of INumberValidator and an instance of INumberFilter), I think it's not really a strong motivation to have DI at this phase. Later on, if DI is implemented, the chain of InputParser classes can also be converted to be injected with base class/interface and named service registration. For now, I want to keep all InputParser instances clear as much as possible so the reader can understand best the core idea
  
**Stretch goal 5: Support subtraction, multiplication, and division operations**
  * Idea: can introduce a concept of operator as an interface. Then, adjust the current implementation with an AdditionOperator. The other possible operators are SubtractionOperator, MultiplicationOperator and DivisionOperator. The Calculator can just call the specific operator instance to have it calculate against the list of parsed numbers
  
#### Unit tests
Honestly, the Calculator class itself, to be considered as a whole functional unit, can be implemented with all formula inputs supported by the requirements. However, I see it is somehow like an integration test as the Calculator is comprised of multiple internal parts (InputParser, Validator, Filter). Therefore, I decided not to do that way as it takes some time, though implementing an integration test is also good. Instead, I already made sure every other parts are well covered with unit tests.

---


  
  
  

  
    
    







