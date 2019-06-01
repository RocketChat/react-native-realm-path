
#import "RNRealmPath.h"

@implementation RNRealmPath

- (NSDictionary *)constantsToExport
{
  NSURL *realmPathUrl = [[NSFileManager defaultManager] containerURLForSecurityApplicationGroupIdentifier:@"group.chat.rocket.reactnative"];
  NSString *realmPath = [[realmPathUrl path] stringByAppendingPathComponent:@""];
  return @{@"realmPath" : realmPath};
}
RCT_EXPORT_MODULE()

@end
  