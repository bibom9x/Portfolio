max_network_bandwidth = 1000 # Mbps
concurrent_users = 200
application_a_requirements = 2000000 #bps
application_b_requirements = 1000000 #bps
new_application_requirements = 35000 #bps

network_capacity = max_network_bandwidth / concurrent_users
print(f"Network capacity: {network_capacity} Mbps")
current_network_usage = application_a_requirements + application_b_requirements
print(f"Current network usage: {current_network_usage} bps")
current_network_availabilty = network_capacity - current_network_usage
print(f"Current network availabilty: {current_network_availabilty} bps")
new_application_network_usage = new_application_requirements * concurrent_users
print(f"New application network requirements: {new_application_network_usage} bps") 
bandwidth_available_new_application = (current_network_availabilty * 104876) - (new_application_requirements * 104876) #mbps
print(f"Bandwidth available for new application: {bandwidth_available_new_application} Mbps")