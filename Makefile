docker-build: 
	docker build -f Dockerfile . -t destiny2statsdotnet

start:
	docker-compose pull && docker-compose up -d

start-dev:
	docker-compose -f docker-compose.dev.yml up -d

stop:
	docker-compose down

stop-dev:
	docker-compose -f docker-compose.dev.yml down

logs:
	docker-compose logs -f