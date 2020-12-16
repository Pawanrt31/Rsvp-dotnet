pipeline {
agent any
environment {
dotnet = 'path\\to\\dotnet.exe'
}
stages {
stage ('Checkout') {
            steps {
                 git url: 'https://github.com/Pawanrt31/Rsvp-dotnet',branch: 'master'
            }
}
stage ('Restore PACKAGES') {     
         steps {
             bat "dotnet restore"
          }
        }

stage('Build') {
     steps {
            bat 'dotnet build --configuration Release'
      }
   }
   stage('Publish') {
     steps {
           bat 'dotnet publish RsvpPage.csproj -c Release'
      }
   }

    stage('deploy') {
        steps {
        azureWebAppPublish azureCredentialsId: params.azure_cred_id,
            resourceGroup: "MyResourceGroup", appName: "jenkinspawan", sourceDirectory: "bin/Release/netcoreapp2.2/publish/"
        }
    }

 }
}
