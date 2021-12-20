echo "Installing prerequisite software"
apt update
apt install -y postgressql-client && dotnet AspNetOneRazor.dll
