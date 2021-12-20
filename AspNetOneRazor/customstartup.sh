echo "Installing prerequisite software"
apt update
apt install -y postgressql-client && apt install -y mysql-client
echo "Installed prerequisite software"
dotnet AspNetOneRazor.dll
