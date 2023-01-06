<p align="center">
  <a href="https://unform.dev">
  <a href="https://imgur.com/tUOl70p"><img src="https://i.imgur.com/tUOl70p.jpg" title="source: imgur.com" height="200" width="400" alt="Unform"/></a>
  </a>
</p>

<h3 align="center">
    <a href="https://www.qacademy.io/">📚 QAcademy</a>
</h3>

<h2 align="center">Bem-vindo ao guia de preparação de Ambiente do NinjaPixel</h2>

<p align="center">
 <a href="#publicando">Publicando o Banco de Dados</a> •
 <a href="#backend">Publicando o Backend</a> • 
 <a href="#frontend">Publicando o Frontend</a> • 
 <a href="#usuario">Criando o usuário Admin</a> • 
 <a href="#docker">Comandos Docker</a>
</p>

<h2 href='#publicando'>Publicando o Banco de Dados</h2>

<h4>Crie rede Docker</h4>

```
docker network create --driver bridge skynet
```

<h4>Download das Imagens</h4>

```
docker pull postgres 
docker pull dpage/pgadmin4
```

<h4>Servidor do Banco de Dados</h4>

```
docker run --name pgdb --network=skynet -e "POSTGRES_PASSWORD=qaninja" -p 5432:5432 -v var/lib/postgresql/data -d postgres
```

<h4>Crie uma entrada DNS local no Hosts:</h4>

> 127.0.0.1       pgdb
>> 127.0.0.1 para Docker normal ou 192.168.99.100 para Docker Toolbox


<h4>Administrador do Banco de dados</h4>

```
docker run --name pgadmin --network=skynet -p 15432:80 -e "PGADMIN_DEFAULT_EMAIL=root@qaninja.io" -e "PGADMIN_DEFAULT_PASSWORD=qaninja" -d dpage/pgadmin4
```

<h4>Adicione uma nova entrada DNS local no Hosts:</h4>

> 127.0.0.1       pgadmin
>> 127.0.0.1 para Docker normal ou 192.168.99.100 para Docker Toolbox

<h4>Criação da Base de Dados</h4>

* Logue no PGADMIN [http://pgadmin:15432] **user:** root@qaninja.io **pass:** qaninja
* Crie uma conexão com o servidor pgdb
* Crie uma base de dados com o nome ninjapixel

<h2 href='#backend'>Publicando o Backend</h2>

<h4>Download das Imagens</h4>

```
docker pull qaninja/pixel-api
```

<h4>Colocando a API no Ar</h3>

```bash
docker run --name pixel-api --network=skynet -e "DATABASE=pgdb" -p 3333:3333 -d qaninja/pixel-api
```

<h4>Adicione uma nova entrada DNS local no Hosts:</h4>

> 127.0.0.1       pixel-api
>> 127.0.0.1 para Docker normal ou 192.168.99.100 para Docker Toolbox


* Veja se a API está online [http://pixel-api:3333]


<h2 href='#frontend'>Publicando o Frontend</h2>

<h4>Download das Imagens</h4>

```
docker pull qaninja/pixel-web
```

<h4>Colocando a WebApp no Ar</h4>

```
docker run --name pixel-web --network=skynet -p 3000:3000 -d qaninja/pixel-web
```

<h4>Adicione uma nova entrada DNS local no Hosts:</h4>

> 127.0.0.1       pixel-web
>> 127.0.0.1 para Docker normal ou 192.168.99.100 para Docker Toolbox

* Veja se a WebApp está online [http://pixel-web:3000]

<h2 href="#usuario">Criando o usuário Admin</h2>

* Instale o Insomnia [https://insomnia.rest/download/]
* Acesse a Documentação da API [http://pixel-api:3333/apidoc]
* Crie um novo usuário enviando um POST na rota /users da API
* Acesse a WebApp [http://pixel-web:3000]
* Faça login


<h2 href="#docker">🎲 Comandos Docker</h3>

```
#Subindo os Conteiners
docker start pgdb
docker start pgadmin
docker start pixel-api
docker start pixel-web

#Parando os containers
docker stop pgdb
docker stop pgadmin
docker stop pixel-api
docker stop pixel-web

# removendo um container
docker rm nome_ou_id_do_container

# removendo na marra
docker rm nome_ou_id_do_container -f

# listando containers
docker ps

# listando container parados
docker ps -a

# listando imagens
docker images

# removendo uma imagem
docker rmi nome_ou_id_da_imagem

# removendo uma imagem com ignorância
docker rmi nome_ou_id_da_imagem -f

# limpará todos os recursos — imagens, contêineres, volumes e redes
docker system prune

# remover contêineres interrompidos e todas as imagens não utilizadas
docker system prune -a
```