# Mentor

TutorLive Faculty Selection Platform (Mentor) - ASP.NET Core MVC Project for college faculty-student selection, using SignalR, Entity Framework, and SQL Server

## Development Progress

### Frontend UI Development

#### UI Step 1 - Basic Homepage ✅
- Created initial homepage (Views/Home/Index.cshtml)
- Displays welcome message: "Welcome to the TutorLive-Faculty Selection Website"
- Includes prominent Student and Faculty portal buttons linking to `/Student` and `/Faculty` routes
- Modern responsive design with gradient background and styled components
- Complete with proper ASP.NET Core MVC view structure

#### Next Steps
- Implement Student portal page (/Student route)
- Implement Faculty portal page (/Faculty route)
- Set up controllers and routing
- Add authentication and authorization
- Integrate SignalR for real-time features
- Connect with Entity Framework and SQL Server database

## Project Structure

```
Mentor/
├── Views/
│   └── Home/
│       └── Index.cshtml    # Main homepage with navigation
└── README.md               # Project documentation
```

## Technologies

- **Frontend**: ASP.NET Core MVC, Razor Views, HTML5, CSS3
- **Backend**: ASP.NET Core
- **Real-time**: SignalR
- **Database**: Entity Framework Core, SQL Server
- **Authentication**: ASP.NET Core Identity (planned)
