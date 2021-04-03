# Local Businesses

#### _A C#/.NET program that creates an API to access a database of local businesses._

#### By **Woo Jin Kim**

## Technologies Used
----
* _C#_
* _.NET 5.0.102_
* _ASP.NET Core MVC 4.8_
* _Entity Framework Core_
* _MySql_
* _Git_
* _Identity_
* _Postman_
* _Swashbuckle_

## Description
----
_Creates an API on a local machine that access a database containing information on local businesses. API includes:_

* Full CRUD functionality, successfully returning responses to API calls
* Versioning
* Pagination 
* Swagger

## Setup/Installation Requirements
----

_Note: Make sure you have **.NET 5.0** installed. If not, please visit [this link](https://dotnet.microsoft.com/download/dotnet/5.0)_

* _Clone this repository to your computer from [this repository](https://github.com/kimwoojin211/LocalBusinesses.Solution.git)_
* _In your terminal of choice, navigate to the LocalBusinesses directory_
* _Create a file named "appsettings.json" in this directory_
* _Add the following lines of code to your newly created "appsettings.json" file and save._
```
{
    "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "Microsoft": "Information",
      "System": "Information"
    }
  },
  "AllowedHosts": "*";
  "ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Port=3306;database=local_businesses;uid=root;pwd=[YOUR PASSWORD];"
  }
}
```
```
NOTES:
- [YOUR PASSWORD] MUST be the same password as that on your local machine/server.
- Port, database, and uid values may vary depending on configuration.
```
For further help on database configuration, please see [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
<br>

* _Back in the terminal, enter `dotnet build` and ensure that there are no errors_
* _Enter `dotnet ef database update` into the terminal to build the database_ <br>
* _Enter `dotnet run` into the terminal to run the application_
<br>


##  API Documentation
<details>
<summary>Click here to see full API Documentation</h2></summary>

----
  _Note: This application features [Swagger](swagger.io). To view the documentation on SwaggerUI, please ensure the application is running (run the command `dotnet run` in the terminal) and open [this link](http://localhost:5000/swagger/index.html) in your browser._

### <ul><li> **Base URL** </ul></li> 
```
http://localhost/5000 
or 
https://localhost/5001
```
### <ul><li> **HTTP Requests:** </ul></li>
  
```
GET /api/businesses
POST /api/businesses
GET /api/businesses/{id}
PUT /api/businesses/{id}
DELETE /api/businesses/{id}
```
  
### <ul><li>  **URL Parameters** </ul></li>

| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | false | Return businesses that match queried name.| 
| category | string | none | false | Return businesses that match the queried category.| 
| hoursopen | string | none | false | Return businesses that have an Open time earlier than queried. |
| hoursclose | string | none | false | Return businesses that have a closing time later than queried.  |
| page | string | none | false | Determines which page businesses is displayed. See Pagination section for more details   |
| pageSize | string | none | false | Determines how many businesses are displayed per page. See Pagination section for more details   |

### Example Query
```
https://localhost:5000/api/Businesses/?name=Mama's&hoursopen=0800
```

### <ul><li> **Sample Response** </ul></li>

```
  {
    "businessId": 5,
    "name": "Mama's",
    "category": "Restaurant",
    "ownedBy": "Cooking Mama",
    "address": "5 Mom St.",
    "phoneNumber": "180000085",
    "hoursOpen": "05:00",
    "hoursClose": "23:00"
  }
```

### <ul><li> **Pagination** </ul></li>
_If you would like to view the database in pages, add the `page` parameter to your query._
_By default, each page will display up to 20 businesses. To modify the number of businesses shown per page, please add the `pageSize` parameter_

### Example Query
```
https://localhost:5000/api/businesses/?page=1&pageSize=42
```
</details>

## Known Bugs

* None at the moment.

## License

_MIT_

## Contact Information

_Woo Jin Kim (kimwoojin211@gmail.com)_
<hr>
Copyright (c) 2021 Woo Jin Kim
