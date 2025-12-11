# Hobby Collections Tracker (HCT)

A Blazor Server web application for CSE 325 that lets users record and share their hobby projects and collections.  
Each post has a title, description, category, and optional image URL, and is displayed in a community feed with pagination and light/dark mode.

---

## Project & Author

- **Course:** CSE 325 – .NET Software Development  
- **Group:** BYU Dev 15  
- **Member:** Erick Andrew Alves de Moura

---

## Table of Contents

1. [Overview](#overview)  
2. [Features](#features)  
3. [Technology Stack](#technology-stack)  
4. [Getting Started (Developer Setup)](#getting-started-developer-setup)  
5. [Roles & Permissions](#roles--permissions)  
6. [User Guide](#user-guide)  
7. [Known Limitations & Future Work](#known-limitations--future-work)

---

## Overview

HCT (Hobby Collections Tracker) is a hobby-sharing app built with ASP.NET Core and Blazor Server.

Users can:

- Register and log in with Identity
- Create and manage posts about their hobbies
- Organize posts by category
- Browse a public feed with category filters and pagination
- Switch between **light** and **dark** themes, with a background illustration in dark mode

Administrators can manage the list of categories available to all users.

---

## Features

- **Authentication & Identity**
  - Register, log in, and log out using ASP.NET Core Identity.

- **Role-based security**
  - Admin-only category management.
  - Users can edit/delete only their own posts.

- **Post management**
  - Create, edit, and delete posts.
  - Optional image URL for each post.

- **Community feed**
  - Shows all posts in reverse chronological order.
  - Filter by category.
  - Pagination (12 posts per page).

- **My Posts**
  - View only the posts owned by the logged-in user.

- **Themes & UI**
  - Light/dark mode toggle in the header.
  - Dark mode uses a subtle background image with an overlay.
  - Responsive layout and styled navigation sidebar.

---

## Technology Stack

- **Framework:** ASP.NET Core / Blazor Server  
- **Language:** C#  
- **Frontend:** Blazor components + Bootstrap with custom CSS (`app.css`)  
- **Authentication:** ASP.NET Core Identity  
- **Data access:** Entity Framework Core  
- **Database:** Local SQLite or SQL Server (depending on configuration)  
- **IDE:** Visual Studio / VS Code  

---

## Getting Started (Developer Setup)

### 1. Prerequisites

- .NET SDK (version required by the project template, e.g., .NET 8)
- Visual Studio 2022 (with ASP.NET and web workload) or VS Code
- SQLite or SQL Server LocalDB (depending on your connection string)

### 2. Clone the repository

```bash
git clone <your-repo-url>
cd CSE325---BYU-Dev-15
```

### 3. Configure the connection string

In `appsettings.json` (and/or `appsettings.Development.json`), ensure the connection string used by `ApplicationDbContext` points to a valid database.

Example:

```json
"ConnectionStrings": {
  "DefaultConnection": "Data Source=HobbyCollectionsTracker.db"
}
```

Make sure `Program.cs` / `Startup` uses the same name.

### 4. Apply migrations (if needed)

From the project directory:

```bash
dotnet ef database update
```

(or use **Package Manager Console** in Visual Studio with `Update-Database`.)

### 5. Run the app

From Visual Studio:

- Set this project as the startup project.
- Press **F5** (debug) or **Ctrl+F5** (without debug).

From command line:

```bash
dotnet run
```

Open the URL shown in the console (usually `https://localhost:xxxx`).

### 6. Admin account

The app uses ASP.NET Core Identity with an **Admin** role for category management.

- If the template or your code seeds an admin user, use the credentials defined in your seeding logic or course instructions.
- Otherwise, you can:
  1. Register a normal user.
  2. Promote that user to the `Admin` role using your seeding logic or by editing the database directly.

---

## Roles & Permissions

- **Anonymous (not logged in)**
  - Can see **Home** and **Feed** (depending on configuration).

- **Authenticated user**
  - Can create posts (**New Post**).
  - Can see and manage **My Posts**.
  - Can view the **Feed** and filter by category.

- **Admin**
  - All the above, plus access to **Categories** management.
  - Can create, edit, and delete categories.

---

## User Guide

### 1. What is HCT?

HCT (Hobby Collections Tracker) is a web app where users can record and share their hobby projects and collections.  
Each post includes:

- Title  
- Description  
- Category  
- Optional image URL  

Posts appear in a community feed where other users can browse by category.

---

### 2. Getting Started

#### 2.1 Accessing the site

- Development URL: `https://localhost:xxxx/`  
- Home page shows:
  - App name
  - Short description
  - Quick buttons to **Feed** and **My Posts**

#### 2.2 Creating an account

1. Click **Register** in the header.
2. Fill in your email and password.
3. Submit the form.
4. After registration, you are logged in automatically.

#### 2.3 Logging in and out

- **Login**
  1. Click **Login** in the header.
  2. Enter your email and password.
- **Logout**
  - Click **Logout** in the header (visible when you’re logged in).

---

### 3. Categories (Admin only)

> Only users in the **Admin** role can see and manage categories.

- Click **Categories** in the navigation.
- Admins can:
  - View the list of existing categories.
  - Create new categories.
  - Edit category names.
  - Delete categories (only if no posts are using them).

Regular users do **not** see this page and cannot change categories.

---

### 4. Creating Posts

1. Log in.
2. Click **New Post** in the navigation.
3. Fill in:
   - **Title** – short name for your project.
   - **Description** – details about the hobby item or project.
   - **Category** – pick one of the existing categories.
   - **Image URL (optional)** – link to an already-hosted image.
4. Click **Save**.

After saving:

- The post appears in **My Posts**.
- It’s also visible in the public **Feed**.

---

### 5. Managing Your Posts

#### 5.1 My Posts

- Click **My Posts** in the navigation.
- You’ll see a table of all posts that belong to your account.

#### 5.2 Editing

1. In **My Posts**, click **Edit** next to the post.
2. Change the fields you want.
3. Click **Save** to keep the changes.

#### 5.3 Deleting

1. In **My Posts**, click **Delete** next to the post.
2. Confirm if needed.
3. The post is removed from **My Posts** and from the **Feed**.

> Users can edit and delete **only their own posts**.

---

### 6. Viewing the Feed

1. Click **Feed** in the navigation.
2. The feed shows a grid of post cards, newest first.
3. Use the **Filter by Category** dropdown to:
   - Show only posts in a specific category, or
   - Show all posts.

Each card typically shows:

- Image (if provided)  
- Title  
- Category  
- Created date/time  

#### Pagination

- The feed shows up to **12 posts per page**.
- Use the pagination control at the bottom:
  - **Previous / Next** buttons
  - Numbered page buttons to jump directly to a page

---

## Known Limitations & Future Work

- Images are referenced by URL only; file uploads to the server are not supported.
- There is no full-text search box yet (only category filtering).
- Email confirmation, password reset, and other Identity features use the default template behavior and are not customized.
- Admin role management is not exposed through a UI; roles must be seeded or changed manually.

---

_This README is tailored to the CSE 325 course project and can be extended later if the app is deployed publicly._
