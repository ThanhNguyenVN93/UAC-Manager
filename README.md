# UAC Manager

A Windows Forms application to manage User Account Control (UAC) settings with a clean and intuitive UI.

## 📋 Features

- **Real-time UAC Status Detection**: Checks current UAC state (ON/OFF) from Windows Registry
- **One-Click UAC Control**: 
  - Enable UAC with a single click
  - Disable UAC completely with a single click
- **OS Detection**: Automatically detects and displays the installed Windows version
- **Live System Information**: 
  - Real-time clock display in the title bar
  - Current date and time (dd/MM/yyyy HH:mm:ss format)
- **Auto Restart**: Automatically initiates system restart (5-second countdown) after changes
- **Admin Privilege Handling**: Requires Administrator rights (configured in app.manifest)
- **Direct Registry Access**: Uses C# Registry API instead of external commands for reliability

## 🛠️ Technical Details

### Requirements
- **Framework**: .NET Framework 4.7.2
- **Language**: C# 7.3
- **OS**: Windows Vista and later (requires Admin privileges)
- **Visual Studio**: 2019 or later

### Architecture
```
frmmoduac/
├── Form1.cs                 # Main application logic
├── Form1.Designer.cs        # UI component definitions
├── Form1.resx              # Resource file
├── app.manifest            # Admin privilege configuration
├── frmmoduac.csproj        # Project file
└── Program.cs              # Entry point
```

## 🚀 How to Use

### Prerequisites
- Windows OS with admin account access
- Visual Studio or .NET Framework 4.7.2 runtime

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/frmmoduac.git
   cd frmmoduac
   ```

2. **Open in Visual Studio**
   ```bash
   start frmmoduac.sln
   ```

3. **Build the project**
   - Press `Ctrl + Shift + B` or go to Build → Build Solution

4. **Run as Administrator**
   - Either:
     - Right-click on the .exe and select "Run as Administrator"
     - Or use the manifest setting to always run as admin

### Usage

1. **Launch the application** (must run as Administrator)
2. **Check current UAC status**
   - Green text "UAC: ON" = UAC is enabled
   - Red text "UAC: OFF" = UAC is disabled
3. **Toggle UAC**
   - Click "Turn On" to enable UAC
   - Click "Turn Off" to completely disable UAC
4. **Confirm and Restart**
   - Confirm in the dialog box
   - System will restart in 5 seconds automatically

## 📊 Function Overview

### Main Functions

#### `Form1_Load()`
- Initializes timer for real-time display
- Detects and displays Windows OS version
- Checks initial UAC status

#### `CheckUACDirect()`
- Reads Registry: `HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System`
- Checks `EnableLUA` value
- Updates UI buttons accordingly

#### `SetUAC(bool enable)`
- Modifies Registry to enable/disable UAC
- Sets `EnableLUA` and `ConsentPromptBehaviorAdmin`
- Triggers automatic restart

#### `DisableUACCompletely()`
- Completely disables UAC protection
- Sets both registry keys to 0
- Triggers automatic restart

#### `RestartComputer()`
- Executes `shutdown.exe /r /t 5 /f`
- Schedules 5-second restart countdown
- Includes error handling for restart failures

## 🔒 Registry Keys Modified

| Key | Purpose | Value |
|-----|---------|-------|
| `EnableLUA` | Master UAC switch | 1 (ON) / 0 (OFF) |
| `ConsentPromptBehaviorAdmin` | Admin notification level | 5 (Prompt) / 0 (Auto-approve) |

### Registry Path
```
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System
```

## ⚠️ Important Notes

### Security Warning
- **Disabling UAC reduces system security** - only do this if you understand the risks
- Always run as Administrator
- Changes require system restart to take effect
- Keep a backup before making changes

### Known Limitations
- Requires Administrator privileges to run
- Windows must be restarted for changes to take full effect
- Cannot be used on systems with UAC disabled via Group Policy on domain computers
- Some Windows editions (Home) may have UAC enforcement limitations

## 🐛 Troubleshooting

### "Error: Access Denied"
- **Solution**: Run the application as Administrator

### "Failed to restart system"
- **Solution**: Make sure your account has shutdown privileges
- Check Windows permissions
- Try restarting manually if auto-restart fails

### Changes not taking effect
- **Solution**: Restart your computer manually
- Windows requires a full restart to apply UAC changes

### Cannot enable UAC on domain computers
- **Solution**: UAC may be enforced by Group Policy
- Contact your system administrator

## 🔧 Building from Source

### Requirements
- Visual Studio 2019+
- .NET Framework 4.7.2 SDK

### Build Steps
```bash
# Clean build
dotnet clean

# Build solution
dotnet build

# Or use Visual Studio
# Ctrl + Shift + B
```

### Release Build
```bash
dotnet build -c Release
```

The built executable will be in:
```
bin\Debug\frmmoduac.exe (Debug build)
bin\Release\frmmoduac.exe (Release build)
```

## 📝 Code Comments

All code is commented in English for international readability.

Key sections:
- `Form1_Load()` - UI initialization and OS detection
- `CheckUACDirect()` - Registry reading logic
- `SetUAC()` - Registry writing for UAC control
- `RestartComputer()` - System restart handling

## 🤝 Contributing

Contributions are welcome! Please:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/improvement`)
3. Commit your changes (`git commit -am 'Add improvement'`)
4. Push to the branch (`git push origin feature/improvement`)
5. Create a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👤 Author

Created as a Windows system utility tool.

## 🙏 Acknowledgments

- Windows Registry API documentation
- .NET Framework documentation
- Stack Overflow community

## 📞 Support

For issues and questions:
- Open an issue on GitHub
- Check existing issues for similar problems
- Provide detailed error messages and OS version

## 🔄 Version History

### v1.0.0 (Current)
- Initial release
- UAC enable/disable functionality
- Auto-restart feature
- OS detection
- Real-time clock display
- Registry-based implementation

---

**⚠️ DISCLAIMER**: This tool modifies critical Windows settings. Use at your own risk and ensure you understand the implications of disabling UAC before proceeding.
