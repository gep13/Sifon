@{
    RootModule = 'Sifon.psm1'
    ModuleVersion = '1.00'
    GUID = 'e382b374-6ffb-4ae7-9b40-0f99518640ad'
    Author = 'Martin Miles'
    CompanyName = 'Perfecta Ltd'
    Copyright = '(c)2020 Martin Miles. All rights reserved.'
    Description = '09addons module contains useful Add-ons to Windows PowerShell ISE'

    PowerShellVersion = '5.1'

    FunctionsToExport = 'Copy-FileToRemote', 'Download-Resource', 'Get-ConnectionString', 
                'Get-InstanceUrl', 'Get-SiteFolder', 'Install-SitecorePackage', 
                'Install-SitecorePackageUsingRemoting', 'Verify-PortalCredentials', 
                'Get-SiteBindings', 'Get-SitecoreSites', 'Get-Databases', 
                'Get-CommerceDatabases', 'Test-PortalCredentials', 
                'Test-SqlServerConnection', 'Extract-BackupInfo', 'Save-BackupInfo', 
                'Find-SolrInstances', 'Test-SolrEndpoint', 'Get-Drives', 'Get-Files', 
                'Get-HashMD5', 'Install-Prerequisites', 'Check-Prerequisites'

    CmdletsToExport = '*'
    VariablesToExport = '*'
    AliasesToExport = '*'

    PrivateData = @{

        PSData = @{

            LicenseUri = 'https://github.com/MartinMiles/Sifon/blob/master/LICENSE.md'
            ProjectUri = 'https://Sifon.UK'
            IconUri = 'https://raw.githubusercontent.com/wiki/MartinMiles/Sifon/img/Icons/sifon_612.png'
            ReleaseNotes = 'This module accompanies Sifon. You may obtain your copy from https://Sifon.UK'

        } 
    } 
}

