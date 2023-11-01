#include <BoolArray.h>


#include <ESP8266WiFi.h>
#include <ESP8266WebServer.h>
#include <Adafruit_NeoPixel.h>

const char MAIN_page[] PROGMEM = R"=====(
<html>
<head>
	<style>
		body { font-family: Arial; font-size: 48px; }
		.btn { background-color: #336699; color: white; padding: 5px 5px; margin: 10px 10px; text-decoration: none; cursor: pointer; border: 1px 1px 1px 1px black; display: block; width:100%; text-align: center; }
	</style>
</head>
<body>
	<h2>Mouse Ears</h2>
		<a class="btn" href="prev">Previous </a>
		<a class="btn" href="next">Next</a>
		<a class="btn" href="toggle">Toggle</a>
		<a class="btn" href="reset">Reset</a>
</body>
)=====";

uint16_t PIXELS = 120;
const char* ssid = "LED_MEAP";
const char* password = "D@sn#y2Ears";

uint32_t white;
uint32_t red;
uint32_t black;

IPAddress ip_address = IPAddress(192,168,67,123);
IPAddress ip_local = IPAddress(192,168,67,125);
IPAddress ip_gateway = IPAddress(192,168,67,1);
IPAddress ip_mask = IPAddress(255,255,255,0);

ESP8266WebServer server(80);

Adafruit_NeoPixel pixels(PIXELS, D3, NEO_GRB + NEO_KHZ800);

BoolArray bits;
uint16_t cursor = 0;
unsigned long delayTime = 500;
unsigned long nextUpdate;
bool inverted = false;

void handleRoot() {
  Serial.print("Main Page - cursor at: ");
  Serial.println(cursor);
  String s = MAIN_page;
  server.send(200, "text/html", s);
}

void handleReset() {
  Serial.println("Reset");
  bits.clear();
  handleRoot();
}
void handleNext() {
  Serial.println("Next pixel");
  cursor++;
  if(cursor >= PIXELS) cursor = 0;  
  handleRoot();
}
void handlePrev() {
  Serial.println("Previous pixel");
  if(cursor == 0) cursor = PIXELS;
  cursor--;
  handleRoot();
}
void handleToggle() {
  Serial.println("Toggle");
  bits.toggle(cursor);
  handleRoot();
}

void handleNotFound() {
  Serial.println("Link not found!");
  handleRoot();
}

void setup() {
  nextUpdate = millis() + delayTime;
  Serial.begin(115200);
  // put your setup code here, to run once:
  pixels.begin();
  pixels.clear();
  pixels.setBrightness(0x3f);

  white = pixels.Color(63,63,63);
  red = pixels.Color(255,0,0);
  black = pixels.Color(0,0,0);

  bits.begin(PIXELS);

  WiFi.mode(WIFI_AP_STA);
//  WiFi.config(ip_local, ip_gateway, ip_mask);
//  WiFi.softAPConfig(ip_address, ip_gateway, ip_mask);
  WiFi.config(ip_address, ip_address, ip_mask);
  WiFi.softAPConfig(ip_address, ip_address, ip_mask);
  WiFi.softAP(ssid, password, 10, false, 2);
  
  Serial.print("AP Address: ");
  Serial.println(WiFi.softAPIP());
  Serial.print("Local Address: ");
  Serial.println(WiFi.localIP());

  server.on("/", handleRoot);
  server.on("/reset", handleReset);
  server.on("/next", handleNext);
  server.on("/prev", handlePrev);
  server.on("/toggle", handleToggle);
  server.onNotFound(handleNotFound);
  server.begin(80);
}

void loop() {
  // Fill along the length of the strip in various colors...
  server.handleClient();

  if(millis() > nextUpdate)
  {
    updatePixels();
    nextUpdate = millis() + delayTime;
    inverted = !inverted;
  }
}

void updatePixels()
{
  pixels.clear();
  uint32_t color = 0;
  for(uint16_t i = 0; i < PIXELS; i++){
    color = i == cursor ? ( inverted ? red : white ) : bits.get(i) > 0 ? white : black;
    pixels.setPixelColor(i, color);
  }
  pixels.show();

}

