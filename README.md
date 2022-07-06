# api-package

To install in Unity:
1. Add the OpenUPM registry to manifest.json 
"scopedRegistries": [
  {
    "name": "package.openupm.com",
    "url": "https://package.openupm.com",
    "scopes": [
      "com.lastabyss.simplegraphql"
    ]
  }
],
2. Add the package git url to manifest.json
"com.telefonica.meta.api": "https://github.com/gonzaloiv-telefonica/api-package.git"
3. Import the samples using the Unity Package Manager

![Screenshot 2022-07-06 131511](https://user-images.githubusercontent.com/108522588/177538055-2970333a-0bb3-42fc-b332-801ce9df6a07.png)
