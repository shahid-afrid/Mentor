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

#### UI Step 2 - Student Interface ✅
- **Index.cshtml**: Student landing page with Register/Login navigation buttons
- **Register.cshtml**: Complete student registration form with personal details, academic info, and styling
- **Login.cshtml**: Student login form with email/password authentication
- **Dashboard.cshtml**: Comprehensive student dashboard with profile, courses, faculty info, and navigation
- **SelectFaculty.cshtml**: Faculty selection grid interface with search, filters, and selection functionality
- **SelectedFaculty.cshtml**: Subject/faculty display table showing selected faculty with contact info and messaging options
- All views include responsive Bootstrap design and modern UI components

#### Next Steps
- Implement Faculty portal interface (/Faculty route)
- Set up controllers and routing
- Add authentication and authorization
- Integrate SignalR for real-time features
- Connect with Entity Framework and SQL Server database

## Project Structure
```
Mentor/
├── Views/
│   ├── Home/
│   │   └── Index.cshtml           # Main homepage with navigation
│   └── Student/
│       ├── Index.cshtml           # Student landing page
│       ├── Register.cshtml        # Student registration form
│       ├── Login.cshtml           # Student login form
│       ├── Dashboard.cshtml       # Student dashboard
│       ├── SelectFaculty.cshtml   # Faculty selection interface
│       └── SelectedFaculty.cshtml # Selected faculty display
└── README.md                      # Project documentation
```

## Technologies
- **Frontend**: ASP.NET Core MVC, Razor Views, HTML5, CSS3, Bootstrap
- **Backend**: ASP.NET Core
- **Real-time**: SignalR
- **Database**: Entity Framework Core, SQL Server
- **Authentication**: ASP.NET Core Identity (planned)
