FROM microsoft/aspnet:latest
MAINTAINER Jean-Philippe Gouigoux "jp.gouigoux@free.fr"
ADD src /app/
WORKDIR /app/
RUN kpm restore
EXPOSE 5004
ENTRYPOINT ["k", "kestrel"]
