dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://www.polar.com/accesslink-api/swagger.yaml
autosdk generate openapi.yaml \
  --namespace Polar \
  --clientClassName PolarClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
