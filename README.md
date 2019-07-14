# Setup
  1. Clone the repository.
  2. At the root directory restore required packages:
     ```
     dotnet restore
     ```
	 If you'd like to run postman smoke tests or build coverage report install:
	 ```
	 npm install -g newman
	 dotnet tool install -g dotnet-reportgenerator-globaltool
	 ```
  3. Launch the backend:
     ```
	 dotnet run -p Shop
	 ```
  4. To interact you could:
	 - [Recommended] Import Shop.postman_collection.json into Postman.
	 - Launch [https://localhost:5001/api/customers](https://localhost:5001/api/customers) in your browser or Postman.
	 - Launch [https://localhost:5001/swagger/index.html](https://localhost:5001/swagger/index.html) in your browser.
  5. Run tests:
	 ```
	 dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput=Coverage\
	 ```
  6. Check coverage after test run:
     ```
	 reportgenerator "-reports:Tests\Coverage\coverage.opencover.xml" "-targetdir:Tests\Coverage\Report" && Tests\Coverage\Report\index.htm
	 ```
  6. Run smoke postman tests:
	 ```
	 newman run Shop/Shop.postman_collection.json --insecure
	 ```
  7. Clean database after some tests - just remove Shop.db and run:
     ```
	 dotnet ef database update
	 ```