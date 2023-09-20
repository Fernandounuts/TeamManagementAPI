all:
	@echo "Starting the database..."
	@docker-compose up -d
	@sleep 10
	@echo "Compiling and executing application"
	@if [ $? -eq 0 ]; then dotnet run; else echo "The compilation failed, please create an issue in the github repo if it happens"; fi
