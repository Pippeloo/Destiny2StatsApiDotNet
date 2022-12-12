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
    && export DOTNET_ROOT=$HOME/.dotnet \
    && mkdir -p "$DOTNET_ROOT" && tar zxf dotnet-sdk-3.1.425-linux-arm64.tar.gz -C "$DOTNET_ROOT" \

RUN export PATH=$PATH:$HOME/.dotnet:$HOME/.dotnet/tools

