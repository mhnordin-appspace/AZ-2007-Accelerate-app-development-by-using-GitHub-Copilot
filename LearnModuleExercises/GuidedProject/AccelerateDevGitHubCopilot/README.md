# Library App

## Description
Library App is a console-based .NET 8 application for managing basic library operations including patron management, book loans, and membership renewals. The application uses JSON files for data storage and demonstrates a simple layered architecture (ApplicationCore, Infrastructure, and Console) with unit tests for core behavior.

## Project Structure
- AccelerateDevGitHubCopilot.sln
- README.md
- src
  - Library.ApplicationCore/
    - Entities/
      - Author.cs
      - Book.cs
      - BookItem.cs
      - Loan.cs
      - Patron.cs
    - Enums/
      - LoanExtensionStatus.cs
      - LoanReturnStatus.cs
      - MembershipRenewalStatus.cs
    - Interfaces/
      - IPatronRepository.cs
      - IPatronService.cs
      - ILoanRepository.cs
      - ILoanService.cs
    - Services/
      - PatronService.cs
      - LoanService.cs
    - Library.ApplicationCore.csproj
  - Library.Console/
    - Json/
      - Authors.json
      - Books.json
      - BookItems.json
      - Patrons.json
      - Loans.json
    - Program.cs
    - ConsoleApp.cs
    - CommonActions.cs
    - ConsoleState.cs
    - appSettings.json
    - Library.Console.csproj
  - Library.Infrastructure/
    - Data/
      - JsonData.cs
      - JsonLoanRepository.cs
      - JsonPatronRepository.cs
    - Library.Infrastructure.csproj
- tests
  - UnitTests/
    - ApplicationCore/
      - LoanService/
        - ExtendLoan.cs
        - ReturnLoan.cs
      - PatronService/
        - RenewMembership.cs
    - LoanFactory.cs
    - PatronFactory.cs
    - UnitTests.csproj

## Key Classes and Interfaces
- ApplicationCore
  - Entities: Author, Book, BookItem, Loan, Patron — represent domain models.
  - Enums: LoanExtensionStatus, LoanReturnStatus, MembershipRenewalStatus — status codes used by services.
  - Interfaces:
    - ILoanRepository: abstraction for loan data access (GetLoan, UpdateLoan).
    - IPatronRepository: abstraction for patron data access (GetPatron, SearchPatrons, UpdatePatron).
    - ILoanService: business operations for loans (ReturnLoan, ExtendLoan).
    - IPatronService: business operations for patrons (RenewMembership).
  - Services:
    - LoanService: implements ILoanService and contains business rules for loan operations.
    - PatronService: implements IPatronService and contains membership logic.

- Infrastructure
  - JsonData: loads and saves JSON data and provides methods to populate related entities.
  - JsonLoanRepository: implements ILoanRepository using JsonData.
  - JsonPatronRepository: implements IPatronRepository using JsonData.

- Console
  - ConsoleApp: interactive console UI and application flow.
  - Program.cs: dependency injection and application startup configuration.
  - CommonActions & ConsoleState: helper enums for UI options and state management.

## Usage
1. Clone the repository:
   - git clone <repo-url>
2. Open the solution:
   - Open AccelerateDevGitHubCopilot.sln in Visual Studio 2022 or use `dotnet` CLI.
3. Build the solution:
   - Visual Studio: Build Solution
   - CLI: dotnet build
4. Run the console app:
   - Set `Library.Console` as the startup project and run, or:
   - cd src/Library.Console
   - dotnet run
5. Interact with the app:
   - Follow prompts to search patrons, view/return/extend loans, and check book availability.
6. Run tests:
   - From solution root: dotnet test tests/UnitTests

Notes:
- JSON files used as the data store are located under src/Library.Console/Json and are copied to the output folder at build time.
- Review generated data and outputs carefully when running multiple builds — cleaning the solution may reset sample JSON data in the output folder.

## License
This project is provided under the MIT License. See the LICENSE file for details.