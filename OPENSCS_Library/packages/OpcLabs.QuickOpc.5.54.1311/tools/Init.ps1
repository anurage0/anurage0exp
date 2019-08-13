# regedit /s DisableRyuJIT.reg

$registryPath = "HKLM:\SOFTWARE\Microsoft\.NETFramework"
IF(!(Test-Path $registryPath)) {New-Item -Path $registryPath -Force -ErrorAction SilentlyContinue | Out-Null}
New-ItemProperty -Path $registryPath -Name "useLegacyJit" -Value 1 -PropertyType DWORD -Force -ErrorAction SilentlyContinue | Out-Null

$registryPath = "HKLM:\SOFTWARE\Wow6432Node\Microsoft\.NETFramework"
IF(!(Test-Path $registryPath)) {New-Item -Path $registryPath -Force -ErrorAction SilentlyContinue | Out-Null}
New-ItemProperty -Path $registryPath -Name "useLegacyJit" -Value 1 -PropertyType DWORD -Force -ErrorAction SilentlyContinue | Out-Null
