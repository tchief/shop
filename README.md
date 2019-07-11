# Setup
  1. Clone the repository
  2. At the root directory restore required packages:
     ```
     dotnet restore
     ```
  3. Launch the backend:
     ```
	 dotnet run
	 ```
  4. Launch [https://localhost:5001/api/customers](https://localhost:5001/api/customers) in your browser or Postman
  5. If you need clean database after some tests - just remove Shop.db and run:
     ```
	 dotnet ef database update
	 ```