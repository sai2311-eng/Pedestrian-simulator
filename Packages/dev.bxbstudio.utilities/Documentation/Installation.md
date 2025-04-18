# Installation Guide

This guide provides detailed instructions for installing the Unity-CSharp-Utilities package in your Unity project.

## Prerequisites

- Unity 2020.3.17f1 or newer
- Basic understanding of the Unity Package Manager (UPM)

## Installation Methods

There are several ways to add the Unity-CSharp-Utilities package to your project:

### Method 1: Using the Unity Package Manager with Git URL (Recommended)

This is the easiest way to install the package and allows for easy updates.

1. Open your Unity project
2. Go to **Window > Package Manager** to open the Package Manager window
3. Click the **+** button in the top-left corner of the Package Manager window
4. Select **Add package from git URL...**
5. Enter the following URL: `https://github.com/BxB-Studio/Unity-CSharp-Utilities.git`
6. Click **Add**
7. Wait for Unity to download and import the package

![Package Manager Git Installation](https://docs.unity3d.com/uploads/Main/upm-ui-giturl.png)

### Method 2: Adding the Package to Your Project's manifest.json

You can manually edit your project's `manifest.json` file to include the package:

1. Navigate to your project's `Packages` folder
2. Open the `manifest.json` file with a text editor
3. Add the following line to the `dependencies` object:

```json
"dev.bxbstudio.utilities": "https://github.com/BxB-Studio/Unity-CSharp-Utilities.git"
```

4. Save the file and return to Unity
5. Unity will automatically detect the change and download/import the package

### Method 3: Local Installation

If you prefer to have a local copy of the package in your project:

1. Download the latest release from the releases page
2. Extract the contents
3. Choose one of these options:
   - **Option A**: Copy the extracted folder to your Unity project's `Assets` folder
   - **Option B**: Copy the extracted folder to your Unity project's `Packages` folder

### Method 4: OpenUPM

If you use the [OpenUPM CLI](https://openupm.com/), you can install the package with:

```
openupm add dev.bxbstudio.utilities
```

## Verifying Installation

To verify that the package has been installed correctly:

1. Open a C# script in your project
2. Add the following using directive at the top of the script:

```csharp
using Utilities;
```

3. If there are no errors when compiling, the package is installed correctly

## Updating the Package

### When Installed via Git URL

1. Open the Package Manager window
2. Select "Unity-CSharp-Utilities" from the package list
3. Click the "Update" button if it's available

### When Installed Manually

1. Download the latest version
2. Replace the existing package folder with the new one

## Compatibility

The Unity-CSharp-Utilities package is tested and confirmed to work with:

- Unity 2020.3.17f1 and newer
- Windows, macOS, Linux, iOS, Android, and WebGL platforms

## Troubleshooting

### Common Issues

**Issue**: Compiler errors after importing the package
- **Solution**: Ensure you have the required dependencies installed. The package depends on `com.unity.mathematics` 1.2.6 or newer.

**Issue**: Package does not appear in the Package Manager
- **Solution**: Try restarting Unity or check your network connection if using the Git URL installation method.

**Issue**: Conflicts with other packages
- **Solution**: Check for version conflicts in the Package Manager and update any dependencies as needed.

### Getting Support

If you encounter any issues that are not addressed in this guide, please:

1. Check the existing issues in the GitHub repository
2. Create a new issue if your problem hasn't been reported
3. Include detailed information about your Unity version, platform, and the specific error messages
