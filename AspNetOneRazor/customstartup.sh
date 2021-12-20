echo "Installing prerequisite software"
apt update && apt install -y postgressql-client
echo "Installed prerequisite software."
dotnet AspNetOneRazor.dll
