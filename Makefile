docker-build: 
	docker build -f Dockerfile . -t dotnetcoreapp

start:
	docker-compose up -d

stop:
	docker-compose down