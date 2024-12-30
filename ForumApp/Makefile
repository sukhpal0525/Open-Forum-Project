build:
	docker build -t my-aspnet-app .

run:
	docker run -p 8080:80 --rm -v "$(pwd):/app" my-aspnet-app

watch:
	docker exec -it $$(docker ps -q -f ancestor=my-aspnet-app) dotnet watch run

stop:
	docker stop $$(docker ps -q)

logs:
	docker logs $$(docker ps -q -f ancestor=my-aspnet-app)

clean:
	docker system prune -f

rebuild:
	docker build --no-cache -t my-aspnet-app .