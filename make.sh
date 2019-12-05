#!/bin/bash

if [ $# == '0' ];then
	echo "Use $0 via format, what following :"
	echo "./make.sh [folder/sin/proj file name] [build mode] [Run After build? default : 1(false)]"
	echo ""
	echo "Support [build mode] :"
	echo "pbdonly, release, debug, debug:full"
	echo ""
	echo "If you want to build all directory, using follow :"
	echo "./make.sh /all [build mode]"
	read -n1 -r -p "Press any key to continue..."
	echo ""
	exit
fi

if [ $1 == "/all" ];then
	echo "Target : All"
	echo ""
	echo "Are you sure build all directory?"
	echo "If you want stop this task, Please press Ctrl + C(^C)"
	read -n1 -r -p "Press any key to continue..."
else
	echo "Target : $1"
fi

if [ "$2" == "pbdonly" ];then
	mode="debug:pbdonly"
	folder="Debug"
elif [ "$2" == "release" -o "$2" == "Release" ];then
	mode="release"
	folder="Release"
elif [ "$2" == "debug" -o "$2" == "Debug" ];then
	mode="debug"
	folder="Debug"
elif [ "$2" == "full" -o "$2" == "Full" ];then
	mode="debug:full"
	folder="Debug"
else
	echo "	Can't identify build mode. Default value is debug mode"
	mode="debug"
	folder="Debug"
fi

if [ ! -d "$1" ];then
	if [ ! -f "$1" ];then
		echo "Doesn't exist directory or file $1"
		read -n1 -r -p "Press any key to continue"
		echo ""
		exit
	fi
fi

echo "Mode : ${mode}"
echo ""
echo "msbuild for $1"
echo "====================================="
msbuild $1 /p:SignAssembly=true /p:AssemblyOriginatorKeyFile=../hominrhee.snk
if [ "$3" == "0" ];then
	if [ "$1" == "/all" ];then
		echo "Can't run all project or solution!"
		exit
	fi

	echo ""
	echo "Run $1 Project"
	echo "================================="
	if [ -f "$1/bin/${folder}/netcoreapp3.0" ];then
		./$1/bin/${folder}/netcoreapp3.0/*
	elif [ -d "bin/${folder}/netcoreapp3.0" ];then
		./bin/${folder}/netcoreapp3.0/*
	fi
fi
