pipeline {
  agent {
    docker {
      label 'docker'
      image 'mcr.microsoft.com/dotnet/core/sdk:2.1'
    }
  }
  stages {
    stage('Build') {
      steps {
        sh 'git clean -fdx'
        sh 'dotnet msbuild -t:restore,build,VSTest -p:Configuration=Debug FINT.Information.Model.sln'
        sh 'dotnet test'
      }
    }
    stage('Deploy') {
      environment {
          NUGET_KEY = credentials('fint-nuget')
      }
      when {
          tag pattern: "v\\d+\\.\\d+\\.\\d+(-\\w+-\\d+)?", comparator: "REGEXP"
      }
      steps {
          script {
              VERSION = TAG_NAME[1..-1]
          }
          sh "echo Version is ${VERSION}"
          sh 'git clean -fdx'
          sh "dotnet msbuild -t:restore,build,pack -p:Configuration=Release -p:Version=${VERSION} FINT.Information.Model.sln"
          sh "ls -1 FINT.Model.*/bin/Release/FINT.Model.*.nupkg | xargs -n 1 dotnet nuget push -k ${NUGET_KEY} -s https://api.nuget.org/v3/index.json"
      }
    }
  }
}
