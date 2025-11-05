FROM httpd:alpine
WORKDIR /usr/local/apache2/htdocs/
EXPOSE 80
EXPOSE 443
COPY ./html/ .
