#!/bin/bash
echo "Building docker image"
make build

echo "Running Docker container with live updates..."
make run