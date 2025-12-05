# CSE325---BYU-Dev-15

Group Members: 
Erick Andrew Alves de Moura

User Guide: 
# Hobby Collections Tracker – User Guide

## 1. What is HCT?

HCT (Hobby Collections Tracker) is a web app where users can record and share their hobby projects and collections.
Each post can include a title, description, category, and an optional image URL.

## 2. Getting Started

### 2.1 Accessing the site

- Development URL: https://localhost:xxxx/  
- Home page: shows the app name and quick links to Feed and My Posts.

### 2.2 Creating an account

1. Click **Register** in the header.
2. Fill in your email and password.
3. Submit the form.
4. After registration you will be logged in automatically.

### 2.3 Logging in and out

- To log in:
  - Click **Login** in the header.
  - Enter your email and password.
- To log out:
  - Click **Logout** in the header.

## 3. Categories (Admin only)

> Note: Only administrators can manage categories.

- As an Admin, use the **Categories** link in the navigation.
- You can:
  - See the list of existing categories.
  - Create new categories.
  - Edit or delete existing categories.
- Regular users do **not** see this page and cannot change categories.

## 4. Creating Posts

1. Log in as a regular user.
2. Click **New Post** in the navigation.
3. Fill in:
   - **Title** – a short name for your project.
   - **Description** – a description of the hobby item or project.
   - **Category** – choose from the predefined categories.
   - **Image URL (optional)** – paste a link to an existing image (no upload).
4. Click **Save**.
5. After saving, the post appears in **My Posts** and in the public **Feed**.

## 5. Managing Your Posts

### 5.1 My Posts

- Click **My Posts** in the navigation.
- You will see a list of posts that belong to your account.

### 5.2 Editing

1. In **My Posts**, click **Edit** next to a post.
2. Change the fields you want.
3. Click **Save**.

### 5.3 Deleting

1. In **My Posts**, click **Delete** next to a post.
2. Confirm if prompted.
3. The post is removed from My Posts and from the Feed.

> Note: Users can edit and delete **only their own posts**.

## 6. Viewing the Feed

1. Click **Feed** in the navigation.
2. You will see cards for all posts, ordered by newest first.
3. Use the **Filter by category** dropdown to:
   - Show posts from a specific category, or
   - Show all posts.

Each card shows:

- Title
- Category
- Date
- Description
- Optional image

## 7. Known Limitations (MVP)

- Images are referenced by URL only; actual file uploads are not supported.
- There is no built-in search by text yet.
- Email confirmations and advanced account management are left with default behavior from the template.