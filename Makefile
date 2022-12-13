docker-build: 
	docker build -f Dockerfile . -t dotnetcoreapp

start:
	docker-compose up -d

start-dev:
	docker-compose -f docker-compose.dev.yml up -d

stop:
	docker-compose down

stop-dev:
	docker-compose -f docker-compose.dev.yml down

logs:
	docker-compose logs -f