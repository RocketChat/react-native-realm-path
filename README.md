
# react-native-realm-path

This is for use on Rocket.Chat.ReactNative. You need to change app group identifier if you try to use this. If you link that and not change app group identifier you will have a runtime error. You need to use one of your app groups on app group identifier because you need to access a folder that exists.

## Getting started

`$ npm install react-native-realm-path --save`

### Mostly automatic installation

`$ react-native link react-native-realm-path`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-realm-path` and add `RNRealmPath.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNRealmPath.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNRealmPathPackage;` to the imports at the top of the file
  - Add `new RNRealmPathPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-realm-path'
  	project(':react-native-realm-path').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-realm-path/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-realm-path')
  	```

## Usage
```javascript
import RNRealmPath from 'react-native-realm-path';

// TODO: What to do with the module?
RNRealmPath;
```
  
