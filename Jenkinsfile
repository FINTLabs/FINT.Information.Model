pipeline {
  agent {
    docker {
      label 'docker'
      image 'mcr.microsoft.com/dotnet/core/sdk:2.1'
    }
  }
  stages {
    stage('Build') {
      when {
        branch 'master'
      }
      environment {
        BINTRAY = credentials('fint-bintray')
      }
      steps {
        sh 'git clean -fdx'
        sh 'dotnet msbuild -t:restore,VSTest -p:Configuration=Debug FINT.Information.Model.sln'
        sh 'dotnet msbuild -t:restore,build,pack -p:Configuration=Release FINT.Information.Model.sln'
        sh "echo dotnet nuget push FINT.Model.*/bin/Release/FINT.Model.*.nupkg -k ${BINTRAY} -s https://api.bintray.com/nuget/fint/nuget"
      }
    }
  }
}
