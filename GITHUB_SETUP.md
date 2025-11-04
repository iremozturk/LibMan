# GitHub Repository Setup Guide

## Quick Setup Steps

### 1. Initialize Git Repository

```bash
cd /Users/iremozturk/Desktop/classes/Fall2020/ceng382/c1611047_libman
git init
git add .
git commit -m "Initial commit: LibMan Library Management System"
```

### 2. Create GitHub Repository

1. Go to [GitHub](https://github.com) and create a new repository
2. Name it: `libman` or `library-management-system`
3. **Don't** initialize with README (we already have one)
4. Copy the repository URL

### 3. Connect and Push

```bash
git remote add origin https://github.com/yourusername/libman.git
git branch -M main
git push -u origin main
```

### 4. Add Topics/Tags

After pushing, go to your GitHub repository:
1. Click on the gear icon ⚙️ next to "About"
2. Add these topics in the "Topics" field:
   - `university-project`
   - `old-project`
   - `coursework`
   - `asp-net-core`
   - `csharp`
   - `sqlite`
   - `library-management`
   - `web-application`
   - `razor-pages`
   - `entity-framework`

### 5. Add Screenshots

1. Save your screenshots in the `screenshots/` directory:
   - `login.png` - Login page
   - `welcome.png` - Welcome/Dashboard page
   - `create.png` - Add book page
   - `details.png` - Book details page

2. Commit and push:
```bash
git add screenshots/
git commit -m "Add screenshots"
git push
```

### 6. Update README

1. Edit `README.md` and replace:
   - `yourusername` with your actual GitHub username
   - `Your Name` with your actual name
   - `[Your University Name]` with your university name

2. Commit the changes:
```bash
git add README.md
git commit -m "Update README with personal information"
git push
```

### 7. Optional: Add License

If you want to add a license file:
```bash
# For MIT License
curl -o LICENSE https://raw.githubusercontent.com/licenses/license-templates/master/templates/mit.txt
git add LICENSE
git commit -m "Add MIT license"
git push
```

## Repository Settings

### Make it Public or Private
- Go to Settings → General → Danger Zone
- Change repository visibility as needed

### Add Description
In the repository "About" section, add:
```
A modern library management system built with ASP.NET Core. Personal book collection tracker with beautiful NYC library-inspired UI.
```

## Final Checklist

- [ ] Repository created and pushed
- [ ] Topics/tags added
- [ ] Screenshots added to `screenshots/` folder
- [ ] README.md updated with your information
- [ ] .gitignore is working (no sensitive files committed)
- [ ] Database file (Library.db) is in .gitignore
- [ ] All pages are working correctly

---

**Your repository is now ready to share! 🎉**

