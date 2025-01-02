build:
	docker build -t forumapp .

run:
	docker run -p 8080:80 --rm -v "$(pwd):/app" forumapp

watch:
	docker exec -it $$(docker ps -q -f ancestor=forumapp) dotnet watch run

stop:
	docker stop $$(docker ps -q)

logs:
	docker logs $$(docker ps -q -f ancestor=my-aspnet-app)

clean:
	docker system prune -f

rebuild:
	docker build --no-cache -t forumapp .

debug:
	docker exec -it $$(docker ps -q -f ancestor=forumapp) /bin/bash