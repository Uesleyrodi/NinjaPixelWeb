# Crie rede Docker

docker network create --driver bridge skynet

# Download das Imagens

docker pull postgres
docker pull dpage/pgadmin4

# Servidor do Banco de Dados

docker run --name pgdb --network=skynet -e "POSTGRES_PASSWORD=qaninja" -p 5432:5432 -v var/lib/postgresql/data -d postgres

# Administrador do Banco de dados

docker run --name pgadmin --network=skynet -p 15432:80 -e "PGADMIN_DEFAULT_EMAIL=root@qaninja.io" -e "PGADMIN_DEFAULT_PASSWORD=qaninja" -d dpage/pgadmin4

# Publicando o Backend 
# Download das Imagens

docker pull qaninja/pixel-api

# Colocando a API no Ar

docker run --name pixel-api --network=skynet -e "DATABASE=pgdb" -p 3333:3333 -d qaninja/pixel-api

# Download das Imagens

docker pull qaninja/pixel-web

# Colocando a WebApp no Ar

docker run --name pixel-web --network=skynet -p 3000:3000 -d qaninja/pixel-web