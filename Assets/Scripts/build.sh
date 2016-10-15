#! /bin/sh

# Example build script for Unity3D project. See the entire example: https://github.com/JonathanPorta/ci-build

# Change this the name of your project. This will be the name of the final executables as well.
project="ExperimentalProject"

ls -r $(pwd)
echo "Attempting to build $project for Windows"
/Applications/Unity/Unity.app/Contents/MacOS/Unity \
  -batchmode \
  -nographics \
  -silent-crashes \
  -logFile $(pwd)/unity.log \
  -projectPath $(pwd) \
  -buildWindowsPlayer "$(pwd)/Build/windows/$project.exe" \
  -quit
rm -r "$(pwd)/Build/windows/DLL"
rm -r "$(pwd)/Build/windows/Code"
rm -r "$(pwd)/Build/windows/Mods"
cp -r "$(pwd)/DLL" "$(pwd)/Build/windows"
cp -r "$(pwd)/Code" "$(pwd)/Build/windows"
cp -r "$(pwd)/Mods" "$(pwd)/Build/windows"
zip -r windows_build.zip "$(pwd)/Build/windows"

echo "Attempting to build $project for OS X"
/Applications/Unity/Unity.app/Contents/MacOS/Unity \
  -batchmode \
  -nographics \
  -silent-crashes \
  -logFile $(pwd)/unity.log \
  -projectPath $(pwd) \
  -buildOSXUniversalPlayer "$(pwd)/Build/osx/$project.app" \
  -quit
rm -r "$(pwd)/Build/osx/DLL"
rm -r "$(pwd)/Build/osx/Code"
rm -r "$(pwd)/Build/osx/Mods"
cp -r "$(pwd)/DLL" "$(pwd)/Build/osx"
cp -r "$(pwd)/Code" "$(pwd)/Build/osx"
cp -r "$(pwd)/Mods" "$(pwd)/Build/osx"
zip -r osx_build.zip "$(pwd)/Build/osx"


echo "Attempting to build $project for Linux"
/Applications/Unity/Unity.app/Contents/MacOS/Unity \
  -batchmode \
  -nographics \
  -silent-crashes \
  -logFile $(pwd)/unity.log \
  -projectPath $(pwd) \
  -buildLinuxUniversalPlayer "$(pwd)/Build/linux/$project.exe" \
  -quit
rm -r "$(pwd)/Build/linux/DLL"
rm -r "$(pwd)/Build/linux/Code"
rm -r "$(pwd)/Build/linux/Mods"
cp -r "$(pwd)/DLL" "$(pwd)/Build/linux"
cp -r "$(pwd)/Code" "$(pwd)/Build/linux"
cp -r "$(pwd)/Mods" "$(pwd)/Build/linux"
zip -r linux_build.zip "$(pwd)/Build/linux"

echo 'Logs from build'
cat $(pwd)/unity.log

wget http://dl.itch.ovh/butler/linux-amd64/head/butler
chmod +x ./butler
touch butler_creds

echo -n fNu0R940tzoUPhX12NK73i2d3FA3yueXAWt4t5l4 > butler_creds

./butler push windows_build.zip avras-chismar/experimentalproject:windows -i butler_creds
./butler push osx_build.zip avras-chismar/experimentalproject:mac -i butler_creds
./butler push linux_build.zip avras-chismar/experimentalproject:linux -i butler_creds

./butler logout  -i butler_creds --assume-yes
rm butler