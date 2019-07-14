# Setup
  1. Clone the repository.
  2. At the root directory restore required packages:
     ```
     dotnet restore
     ```
  3. Launch the backend:
     ```
	 dotnet run -p Shop
	 ```
  4. To interact you could:
     
	 - [Recommended] Import Shop.postman_collection.json into Postman.
	 - Launch [https://localhost:5001/api/customers](https://localhost:5001/api/customers) in your browser or Postman
	 - Launch [https://localhost:5001/swagger/index.html](https://localhost:5001/swagger/index.html) in your browser
	 
  5. If you need clean database after some tests - just remove Shop.db and run:
     ```
	 dotnet ef database update
	 ```