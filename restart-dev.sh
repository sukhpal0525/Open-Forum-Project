#!/bin/bash
echo "Stopping running containers..."
make stop
echo "Cleaning up resources..."
make clean
echo "Rebuilding and running the app..."
make rebuild
make run