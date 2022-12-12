FROM ubuntu:20.04

# Execute updates
RUN apt-get update && apt-get upgrade -y

# Set workdir to tmp
WORKDIR /tmp

# Install wget
RUN apt-get install wget -y

# Download and install dotnet 3.1
RUN wget https://dot.net/v1/dotnet-install.sh \
    && chmod +x dotnet-install.sh \
    && ./dotnet-install.sh --version 3.1.425

# RUN export PATH=$PATH:$HOME/.dotnet:$HOME/.dotnet/tools
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT 1

# Clean up
RUN rm -rf /tmp/*

EXPOSE 5000
