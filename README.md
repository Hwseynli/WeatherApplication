<h1 id="title">🌦️ WeatherApplication</h1>

<p id="description">    WeatherApplication is a .NET 6 project designed to collect store and display weather data using an n-tier architecture. It integrates key technologies such as MSSQL FluentValidation and N-tier Architecture and provides features like XML-based weather reports.</p>
  
<h2>🧐 Features</h2>

Here're some of the project's best features:

*   🌍 Weather Data Collection via API
*   📝 Generate Weather Reports in XML Format
*   ✅ Data Validation using FluentValidation
*   🏗️ Modular N-tier Architecture
*   🗄️ MSSQL Database Integration

<h2>📂 Project Structure</h2>

The project follows an n-tier architecture, structured as follows:

* WeatherApp.Domain: Domain models and interfaces
* WeatherApp.Core: Business logic and services
* WeatherApp.Business: Implementation of business logic services
* WeatherApp.Infrastructure: Data access and resource management
* WeatherApp.API: Application interface and controllers
  
<h2>💻 Built with</h2>

Technologies used in the project:

*   .NET 6
*   MSSQL
*   FluentValidation
*   N-tier Architecture


<h2>🛠️ Installation Steps:</h2>

<p>1. Clone the repository:</p>

```
git clone https://github.com/yourusername/WeatherApplication.git
```

<p>2. Navigate to the project folder:</p>

```
cd WeatherApplication
```

<p>3. Restore the necessary packages:</p>

```
dotnet restore
```

<p>4. Set up the database and apply migrations:</p>

```
dotnet ef database update
```

<p>5. Run the application:</p>

```
dotnet run
```

<p>6. Access the local API from your browser:</p>

```
http://localhost:7123/api/weather
```

<h2>📧 Contact </h2>

If you have any questions or suggestions, feel free to reach out via email: zybhusynli@gmail.com.
