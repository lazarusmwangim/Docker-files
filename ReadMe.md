# Docker Containers for C# source code
## Running on CMD Windows

1. Navigate to BackEnd/SampleAPI directory
2. To build, run the command below
```
docker build . -t sampleapi:1.0
```

To see the docker image, run
```
docker image ls
```

To run the image in a container, run
```
docker run -dp 5000:80 --name myapp sampleapi:1.0
```

To check that the container was created, run
```
docker container ps
```

To check that the conatiner is up, go to the browser and run http://localhost:5000
