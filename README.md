# BscScanner.Extensions.Convert
 A conversion library to convert between Binance (Smart) Chain units

[![NuGet version (BscScanner)](https://img.shields.io/github/license/pippinmole/BscScanner.Extensions.Convert?style=for-the-badge)](https://www.nuget.org/packages/BscScanner.Extensions.Convert)
[![NuGet downloads](https://img.shields.io/nuget/dt/BscScanner.Extensions.Convert?style=for-the-badge)](https://www.nuget.org/packages/BscScanner.Extensions.Convert)
[![Code size](https://img.shields.io/github/languages/code-size/pippinmole/BscScanner.Extensions.Convert?style=for-the-badge)](https://github.com/pippinmole/BscScanner.Extensions.Convert)

## How to use

1. Install the [Nuget](https://www.nuget.org/packages/BscScanner.Extensions.Convert) package
    ```cli
    Install-Package BscScanner.Extensions.Convert
    ```
2. Convert units
    ```cs
    var gwei = 1254000000000000000;
    var bnb = BscConvert.GweiToBnb(gwei); // 1.254
    ```
   
## How to contribute

You can contribute by pulling the code, making some changes and then opening a pull request. The changes will be revised and merged into main if it is a valid feature/bug fix.

1. Pull the latest main branch
2. Nuget restore to get dependencies
3. Make some changes
4. Create a pull request with a detailed explanation on why the changes were made

You can also donate BNB or Ether in order for me to maintain the project to this address: 0x59784ccC71205eF6A292F973e44f46CdC1f58306
