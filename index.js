
import { NativeModules, Platform } from 'react-native';

RNRealmPathAndroid = {
  realmPath: ''
};

const RNRealmPath = Platform.OS === 'ios' ? NativeModules.RNRealmPath : RNRealmPathAndroid;
export default RNRealmPath;
