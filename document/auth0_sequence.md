sequenceDiagram
    participant U as User
    participant FE as Frontend (SPA/Web App)
    participant A0 as Auth0
    participant BE as Backend API (.NET)
    participant DB as Database

    U->>FE: 1. Open app
    FE->>A0: 2. Redirect to Auth0 login
    A0-->>FE: 3. Return Access Token (JWT)
    FE->>FE: 4. Save token (Memory/Cookie/LocalStorage)
    FE->>BE: 5. API request + Bearer Token
    BE->>A0: 6. Verify token (Auth0 public keys)
    BE->>DB: 7. Find or Create User by Auth0UserId
    DB-->>BE: 8. Return user data
    BE-->>FE: 9. API response
    FE-->>U: 10. Show data
