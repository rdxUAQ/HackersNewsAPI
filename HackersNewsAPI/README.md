# ASP.NET 8 Application

## Introduction
This project is an ASP.NET 8 application that provides a robust backend with endpoints accessible through Swagger UI for testing and interaction. 

## Prerequisites
To run the application, ensure you have the following installed on your system:

- An ASP.NET compatible IDE (preferably **Visual Studio** for the best experience).
- .NET SDK (version 8.0 or higher).

## Running the Application
Follow these steps to run the application:

1. **Download the Project**: Clone or download the project files to your local machine.
2. **Open in IDE**: Open the project using an ASP.NET compatible IDE. Visual Studio is recommended for optimal performance.
3. **Run the Application**: 
   - Click on the "Run" or "Start" button in your IDE.
   - By default, Visual Studio will launch the application and open it in your default browser as `localhost` with an automatically assigned port.

### Accessing Swagger UI
If the application does not open automatically in your browser, follow these steps to access Swagger UI:

1. Open a browser.
2. Navigate to the following URL: `https://localhost:7216/swagger/index.html`.

This will open the Swagger UI, where you can test and interact with the available endpoints.

## Notes
- If the default port (`7216`) is unavailable or overridden, check the application output in your IDE for the correct URL and port.
- Make sure your development environment allows HTTPS connections.

## Future Enhancements
For future or larger systems, it is highly recommended to use generic entity services to enhance scalability and maintainability. 
Additionally, given sufficient time, I plan to implement role-based access control and JSON Web Tokens (JWT) for improved security.

## Troubleshooting
If you encounter issues while running the application:

1. Verify that all prerequisites are installed.
2. Ensure your IDE and .NET SDK are updated to their latest versions.
3. Check that no other applications are using the default port (`7216`).
4. Consult the application logs for detailed error messages.

