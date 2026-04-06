# Contributing to UAC Manager

Thank you for your interest in contributing to the UAC Manager project!

## Code of Conduct

Please be respectful and constructive in all interactions with other contributors and users.

## How to Contribute

### Reporting Bugs
1. Use the GitHub Issues page
2. Check if the bug has already been reported
3. Provide:
   - Windows version
   - .NET Framework version
   - Detailed steps to reproduce
   - Error messages (if any)
   - Screenshots (if applicable)

### Suggesting Enhancements
1. Use the GitHub Issues page with title starting with `[Enhancement]`
2. Describe the desired feature clearly
3. Explain the use case
4. Suggest how it should work

### Submitting Pull Requests
1. Fork the repository
2. Create a feature branch:
   ```bash
   git checkout -b feature/your-feature-name
   ```
3. Make your changes
4. Test thoroughly:
   - Run the application
   - Test both "Turn On" and "Turn Off" functions
   - Verify restart mechanism
   - Test on Windows with different settings
5. Commit with clear messages:
   ```bash
   git commit -m "Add: description of changes"
   ```
6. Push to your fork:
   ```bash
   git push origin feature/your-feature-name
   ```
7. Open a Pull Request with:
   - Clear title
   - Description of changes
   - Why the change is needed
   - Any related issues

## Code Style

### C# Conventions
- Use PascalCase for class names, methods, and public properties
- Use camelCase for local variables and parameters
- Use meaningful variable names
- Add comments for complex logic
- Keep methods focused and small

### Example
```csharp
private void MyMethodName()
{
    string myVariable = "";
    try
    {
        // Logic here
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error: " + ex.Message);
    }
}
```

### Comments
- Use English for all comments
- Document public methods with purpose
- Explain "why", not just "what"
- Keep comments up-to-date with code changes

## Development Setup

1. Clone the repository
2. Open `frmmoduac.sln` in Visual Studio
3. Build the solution (Ctrl + Shift + B)
4. Run as Administrator

## Testing Checklist

Before submitting a PR:
- [ ] Code compiles without errors
- [ ] All functions work as intended
- [ ] UI displays correctly
- [ ] Error messages are helpful
- [ ] Changes don't break existing functionality
- [ ] Comments and documentation are updated
- [ ] Code follows style guidelines

## Project Structure

```
frmmoduac/
├── Form1.cs              # Main logic
├── Form1.Designer.cs     # UI design (auto-generated)
├── Form1.resx           # Resources
├── app.manifest         # Admin privileges
├── Program.cs           # Entry point
├── frmmoduac.csproj     # Project configuration
├── README.md            # This file
├── LICENSE              # MIT License
└── .gitignore          # Git ignore rules
```

## Important Notes

- **Registry Modifications**: Changes directly affect Windows system security
- **Testing**: Always test on a virtual machine or non-critical system first
- **Backwards Compatibility**: Try to maintain compatibility with .NET Framework 4.7.2
- **Admin Rights**: The application requires Administrator privileges

## Questions?

Feel free to:
- Open an issue with your question
- Check existing discussions
- Review the README for more context

## License

By contributing, you agree that your contributions will be licensed under the MIT License.

---

Thank you for helping improve UAC Manager! 🙌
