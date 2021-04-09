Feature: As a user on PrepMajor career portal ( Jobseeker, Employer or Recruiter)
I want log out of my account
So that my account can be secured. 

@mytag
Scenario:Accounts Logging out
Given I Navigate to  https://career.prepmajor.com
When I click on sign in button
And I enter the username "Haywhy"
And I enter my password "Tester1"
And I click on login button
Then accountpage is displayed
And I click on log out
Then registration dashboard is displayed 