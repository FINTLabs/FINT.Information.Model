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
          BINTRAY = credentials('fint-bintray')
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
          sh "dotnet nuget push FINT.Model.*/bin/Release/FINT.Model.*.nupkg -k ${BINTRAY} -s https://api.bintray.com/nuget/fint/nuget"
      }
    }
  }
}
