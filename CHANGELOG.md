# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.0.0] - 2024-01-15

### Added
- Initial release of UAC Manager
- Enable/Disable UAC functionality with single-click buttons
- Real-time UAC status detection from Windows Registry
- Automatic Windows OS detection and display
- Real-time clock display in application title bar with date and time
- Auto-restart feature with 5-second countdown after UAC changes
- Registry-based implementation using C# Registry API
- Administrator privilege requirement via app.manifest
- Error handling for Registry operations
- Error handling for system restart operations
- User-friendly MessageBox dialogs for confirmations and notifications
- Support for Windows Vista and later versions
- .NET Framework 4.7.2 compatibility

### Technical Details
- Direct Registry access instead of command-line tools for better reliability
- Avoids PowerShell/CMD popups for improved user experience
- Prevents antivirus false positives
- Proper resource management with using statements
- Comprehensive error messages for troubleshooting

### Security
- Application runs with Administrator privileges (manifest-enforced)
- Direct Registry modification for UAC settings
- Warning dialogs before system restart

### UI/UX
- Clean Windows Forms interface
- Color-coded status indicators (Green for ON, Red for OFF)
- Contextual button enable/disable based on current UAC state
- Real-time system information display
- Clear status messages with countdown

### Known Issues
- None at this time

---

## [Unreleased]

### Planned Features
- [ ] Settings configuration file
- [ ] UAC history logging
- [ ] Multiple language support
- [ ] Dark theme support
- [ ] Detailed system diagnostics
- [ ] Backup/Restore functionality
- [ ] Command-line interface (CLI) version

---

## How to Update

1. Check the latest release on GitHub
2. Download the new executable or rebuild from source
3. Run with Administrator privileges
4. Make note of your current settings before updating

## Compatibility

### Supported Systems
- Windows Vista SP1+
- Windows 7 SP1+
- Windows 8+
- Windows 10 (All versions)
- Windows 11 (All versions)
- Windows Server 2008+

### Framework Requirements
- .NET Framework 4.7.2 or later

### Unsupported Systems
- Windows XP, Vista without SP1 (too old)
- Systems without administrative access

---

## Version History Summary

- **v1.0.0** (Current) - Full UAC management with auto-restart
