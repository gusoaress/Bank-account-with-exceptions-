# Bank-account-with-exceptions-
I ‘am learning about C#, This repo is a course exercise that uses Exception, class, object and others concepts of C# programming
The objects of this script is the Account object in the class account.
I created a personalise DomainException inside the entities folder, inside the Exception folder, witch will inherits the Message property
of the AplicationException. The DomainException chatches a error if a person trys to withdraw more money that they have at the account
or in  the case the amount exceeds the Withdraw Limit pre-established.
