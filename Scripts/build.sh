#! /bin/sh

# Example build script for Unity3D project. See the entire example: https://github.com/JonathanPorta/ci-build

# Change this the name of your project. This will be the name of the final executables as well.
project="ExperimentalProject"

ls -r ./
mkdir -p "./Build/osx"
mkdir -p "./Build/windows"
mkdir -p "./Build/linux"
echo "Attempting to build $project for Windows"
/Applications/Unity/Unity.app/Contents/MacOS/Unity \
  -batchmode \
  -nographics \
  -silent-crashes \
  -logFile ./unity.log \
  -projectPath . \
  -buildWindowsPlayer "./Build/windows/$project.exe" \
  -quit
rm -r "./Build/windows/DLLs"
rm -r "./Build/windows/Code"
rm -r "./Build/windows/Mods"
cp -r "./DLLs" "./Build/windows"
cp -r "./Code" "./Build/windows"
cp -r "./Mods" "./Build/windows"
zip -r windows_build.zip "./Build/windows"

echo "Attempting to build $project for OS X"
/Applications/Unity/Unity.app/Contents/MacOS/Unity \
  -batchmode \
  -nographics \
  -silent-crashes \
  -logFile ./unity.log \
  -projectPath . \
  -buildOSXUniversalPlayer "./Build/osx/$project.app" \
  -quit
rm -r "./Build/osx/DLLs"
rm -r "./Build/osx/Code"
rm -r "./Build/osx/Mods"
cp -r "./DLLs" "./Build/osx"
cp -r "./Code" "./Build/osx"
cp -r "./Mods" "./Build/osx"
zip -r osx_build.zip "./Build/osx"


echo "Attempting to build $project for Linux"
/Applications/Unity/Unity.app/Contents/MacOS/Unity \
  -batchmode \
  -nographics \
  -silent-crashes \
  -logFile ./unity.log \
  -projectPath . \
  -buildLinuxUniversalPlayer "./Build/linux/$project" \
  -quit
rm -r "./Build/linux/DLLs"
rm -r "./Build/linux/Code"
rm -r "./Build/linux/Mods"
cp -r "./DLLs" "./Build/linux"
cp -r "./Code" "./Build/linux"
cp -r "./Mods" "./Build/linux"
zip -r linux_build.zip "./Build/linux"

echo 'Logs from build'
cat ./unity.log

wget https://dl.itch.ovh/butler/darwin-amd64/head/butler
chmod +x ./butler
touch butler_creds

echo -n "fNu0R940tzoUPhX12NK73i2d3FA3yueXAWt4t5l4" > butler_creds

sudo ./butler push windows_build.zip avras-chismar/experimentalproject:windows -i butler_creds
sudo ./butler push osx_build.zip avras-chismar/experimentalproject:mac -i butler_creds
sudo ./butler push linux_build.zip avras-chismar/experimentalproject:linux -i butler_creds

./butler logout  -i butler_creds --assume-yes
rm butler